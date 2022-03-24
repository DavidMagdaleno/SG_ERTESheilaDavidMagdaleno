using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SG_ERTESheilaDavidMagdaleno
{
    public partial class frmNewEmpre : Form
    {
        private List<int> aux;
        public frmNewEmpre()
        {
            InitializeComponent();
            cargarSector();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void cargarSector()
        {
            using (bd_ertesEntities objBD = new bd_ertesEntities())
            {
                var consulta = from sec in objBD.SECTORES
                               select sec;

                var n = consulta.Distinct().ToList();
                //objBD.SaveChanges();
                for (int i = 0; i < n.Count; i++)
                {
                    aux.Add(n[i].Id_sector);
                    cbSec.Items.Add(n[i].Descripcion);
                }
            }
        }

        private void btnAcep_Click(object sender, EventArgs e)
        {
            using (bd_ertesEntities objBD = new bd_ertesEntities())
            {
                EMPRESAS objEmp = objBD.EMPRESAS.Find(txtCif.Text);

                if (objEmp != null)
                {
                    MessageBox.Show("Esa Empresa ya existe");
                }
                else
                {
                    objEmp = objBD.EMPRESAS.Create();
                    objEmp.Cif = txtCif.Text;
                    objEmp.Nombre = txtNom.Text;
                    objEmp.Domicilio = txtDom.Text;
                    objEmp.Sector = aux[cbSec.SelectedIndex];
                    //se guardan los cambios
                    objBD.EMPRESAS.Add(objEmp);
                    objBD.SaveChanges();
                    MessageBox.Show("Añadido");

                }
            }
        }
    }
}
