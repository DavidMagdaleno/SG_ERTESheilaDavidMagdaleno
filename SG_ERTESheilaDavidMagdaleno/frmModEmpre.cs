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
    public partial class frmModEmpre : Form
    {
        private String cif;
        private int idsec;
        private List<int> listaux= new List<int>();
        public frmModEmpre(String c, int i)
        {
            InitializeComponent();
            cif = c;
            idsec = i;
            txtCif.Text = cif;
            cargarIni();
            cargarSectores();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void cargarSectores()
        {
            string aux="";
            using (bd_ertesEntities objBD = new bd_ertesEntities())
            {
                var consulta = from sec in objBD.SECTORES
                               select sec;

                var n = consulta.Distinct().ToList();
                for (int i = 0; i < n.Count; i++)
                {
                    listaux.Add(n[i].Id_sector);
                    cbSec.Items.Add(n[i].Descripcion);
                    if (n[i].Id_sector == idsec) {
                        aux = n[i].Descripcion;
                    }
                }
            }
            cbSec.SelectedItem = aux;
        }

        public void cargarIni()
        {
            using (bd_ertesEntities objBD = new bd_ertesEntities())
            {
                var consulta = from emp in objBD.EMPRESAS
                               select emp;

                var n = consulta.Distinct().ToList();
                for (int i = 0; i < n.Count; i++)
                {
                    if (n[i].Cif.Equals(cif)) {
                        txtNom.Text = n[i].Nombre;
                        txtDom.Text = n[i].Domicilio;
                    }
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
                    objEmp.Nombre = txtNom.Text;
                    objEmp.Domicilio = txtDom.Text;
                    objEmp.Sector = listaux[cbSec.SelectedIndex];
                    //se guardan los cambios
                    objBD.SaveChanges();
                    MessageBox.Show("Modificado");
                }
                else
                {
                    MessageBox.Show("Esa Empresa no existe");
                }
            }
        }
    }
}
