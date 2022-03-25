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
    public partial class frmNewErte : Form
    {
        public frmNewErte()
        {
            InitializeComponent();
            cargarEmpresas();
        }

        List<string> listaux = new List<string>();
        public void cargarEmpresas()
        {
            using (bd_ertesEntities objBD = new bd_ertesEntities())
            {
                var consulAux = from er in objBD.ERTES
                                where er.Fecha_fin==null
                                select er.Empresa;
                var t = consulAux.Distinct().ToList();
                if (t.Count > 0)
                {
                    var consulta = from emp in objBD.EMPRESAS
                                   from er in consulAux
                                   where !consulAux.Contains(emp.Cif)
                                   orderby emp.Nombre
                                   select emp;

                    var n = consulta.Distinct().ToList();
                    for (int i = 0; i < n.Count; i++)
                    {
                        listaux.Add(n[i].Cif);
                        cb_em.Items.Add(n[i].Nombre);
                    }
                }
                else {
                    var consulta = from emp in objBD.EMPRESAS
                                   orderby emp.Nombre
                                   select emp;

                    var n = consulta.Distinct().ToList();
                    for (int i = 0; i < n.Count; i++)
                    {
                        listaux.Add(n[i].Cif);
                        cb_em.Items.Add(n[i].Nombre);
                    }
                }
                
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            using (bd_ertesEntities objBD = new bd_ertesEntities())
            {
                
                ERTES objEr = objBD.ERTES.Create();
                objEr.Empresa = listaux[cb_em.SelectedIndex];
                objEr.Fecha_inicio = DateTime.Today;
                //se guardan los cambios
                objBD.ERTES.Add(objEr);
                objBD.SaveChanges();
                MessageBox.Show("Añadido");
                this.Close();
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
