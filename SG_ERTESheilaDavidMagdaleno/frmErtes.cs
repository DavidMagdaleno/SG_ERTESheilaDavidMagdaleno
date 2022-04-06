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
    public partial class frmErtes : Form
    {
        public frmErtes()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (bd_ertesEntities objBD = new bd_ertesEntities())
            {
                var consulta = from emple in objBD.EMPLEADOS
                               group emple by emple.Empresa into grupo
                               select new
                               {
                                   empr = grupo.Key,
                                   Num_veces = grupo.Count()
                               };

                var consulta2 = from emp in objBD.EMPRESAS
                                from sec in objBD.SECTORES
                                from er in objBD.ERTES
                                from emple in consulta
                                where sec.Id_sector == emp.Sector && emp.Cif == er.Empresa && emp.Cif == emple.empr && er.Fecha_inicio >= dtIniDesde.Value.Date && er.Fecha_inicio <= dtIniHasta.Value.Date && (er.Fecha_fin >= dtFinDesde.Value.Date || er.Fecha_fin == null) && (er.Fecha_fin <= dtFinHasta.Value.Date || er.Fecha_fin == null)
                                orderby emp.Nombre
                                select new { Empresa = emp.Nombre, CIF = emp.Cif, Sector = sec.Descripcion, NºEmpleados = emple.Num_veces, FInicio = er.Fecha_inicio, FFin = er.Fecha_fin, er.Id_erte };


                if (!txtNomEmp.Text.Equals(""))
                {
                    var subConsulta = consulta2.Where(x => x.Empresa == txtNomEmp.Text).Distinct().ToList();
                    if (subConsulta.Count > 0)
                    {

                        dgvErtes.DataSource = subConsulta;
                        dgvErtes.Columns[6].Visible = false;
                    }
                }

                if (!txtNomSec.Text.Equals(""))
                {
                    var subConsulta = consulta2.Where(x => x.Sector == txtNomSec.Text).Distinct().ToList();
                    if (subConsulta.Count > 0)
                    {
                        dgvErtes.DataSource = subConsulta;
                        dgvErtes.Columns[6].Visible = false;
                    }
                }
                if (!txtNumEmple1.Text.Equals(""))
                {
                    int aux = int.Parse(txtNumEmple1.Text);
                    var subConsulta = consulta2.Where(x => x.NºEmpleados >= aux).Distinct().ToList();
                    if (subConsulta.Count > 0)
                    {
                        dgvErtes.DataSource = subConsulta;
                        dgvErtes.Columns[6].Visible = false;
                    }
                }

                if (!txtNumEmple2.Text.Equals(""))
                {
                    int aux = int.Parse(txtNumEmple2.Text);
                    var subConsulta = consulta2.Where(x => x.NºEmpleados <= aux).Distinct().ToList();
                    if (subConsulta.Count > 0)
                    {
                        dgvErtes.DataSource = subConsulta;
                        dgvErtes.Columns[6].Visible = false;
                    }
                }

                if (!txtNumEmple1.Text.Equals("") && !txtNumEmple2.Text.Equals(""))
                {
                    int aux = int.Parse(txtNumEmple1.Text);
                    int aux2 = int.Parse(txtNumEmple2.Text);
                    var subConsulta = consulta2.Where(x => x.NºEmpleados >= aux
                    && x.NºEmpleados <= aux2).Distinct().ToList();
                    if (subConsulta.Count > 0)
                    {
                        dgvErtes.DataSource = subConsulta;
                        dgvErtes.Columns[6].Visible = false;
                    }
                }
            }
        }

        private void btnFinErte_Click(object sender, EventArgs e)
        {
            if (dgvErtes.SelectedRows.Count > 0)
            {
                if (dgvErtes.SelectedRows[0].Cells[5].Value == null)
                {
                    using (bd_ertesEntities objBD = new bd_ertesEntities())
                    {
                        ERTES objErt = objBD.ERTES.Find(dgvErtes.SelectedRows[0].Cells[6].Value);
                        objErt.Fecha_fin = DateTime.Today;
                        objBD.SaveChanges();
                        MessageBox.Show("El ERTE ha sido finalizado");
                        btnBuscar.PerformClick();
                    }

                }
                else
                {
                    MessageBox.Show("Ese ERTE ya esta Finalizado");
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningun ERTE");
            }
        }

        private void btnNewErte_Click(object sender, EventArgs e)
        {
            frmNewErte f1 = new frmNewErte();
            f1.ShowDialog();
        }

        private void txtNumEmple1_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarNumeros(e);
        }

        private void comprobarNumeros(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtNumEmple2_KeyPress(object sender, KeyPressEventArgs e)
        {
            comprobarNumeros(e);
        }
    }
}
