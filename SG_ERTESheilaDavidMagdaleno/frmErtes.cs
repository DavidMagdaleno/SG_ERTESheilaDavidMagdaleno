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
            if (!txtNomEmp.Text.Equals(""))
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
                                    where emp.Nombre == txtNomEmp.Text && sec.Id_sector == emp.Sector && emp.Cif == er.Empresa && emp.Cif == emple.empr
                                    orderby emp.Nombre
                                    select new { Empresa = emp.Nombre, CIF = emp.Cif, Sector = sec.Descripcion, NºEmpleados = emple.Num_veces, FInicio = er.Fecha_inicio, FFin = er.Fecha_fin, er.Id_erte };

                    var r = consulta2.Distinct().ToList();

                    if (r.Count > 0)
                    {
                        dgvErtes.DataSource = r;
                        dgvErtes.Columns[6].Visible = false;
                    }
                }
            }
            else
            {
                //Busqueda por Sector---------------------------------------------------------------------
                if (!txtNomSec.Text.Equals(""))
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
                                        where sec.Descripcion == txtNomSec.Text && sec.Id_sector == emp.Sector && emp.Cif == er.Empresa && emp.Cif == emple.empr
                                        orderby emp.Nombre
                                        select new { Empresa = emp.Nombre, CIF = emp.Cif, Sector = sec.Descripcion, NºEmpleados = emple.Num_veces, FInicio = er.Fecha_inicio, FFin = er.Fecha_fin, er.Id_erte };

                        var r = consulta2.Distinct().ToList();

                        if (r.Count > 0)
                        {
                            dgvErtes.DataSource = r;
                            dgvErtes.Columns[6].Visible = false;
                        }
                    }
                }
                else
                {
                    //Busqueda por Nº Empleados---------------------------------------------------------------------
                    if (!txtNumEmple1.Text.Equals("") && !txtNumEmple2.Text.Equals(""))
                    {
                        bool valido;
                        bool valido2;
                        int aux;
                        int aux2;
                        valido = int.TryParse(txtNumEmple1.Text, out aux);
                        valido2 = int.TryParse(txtNumEmple1.Text, out aux2);
                        if ((valido && valido) || (valido && !valido2) || (!valido && valido2))
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
                                                where emple.Num_veces >= aux && emple.Num_veces <= aux2 && sec.Id_sector == emp.Sector && emp.Cif == er.Empresa && emp.Cif == emple.empr
                                                orderby emp.Nombre
                                                select new { Empresa = emp.Nombre, CIF = emp.Cif, Sector = sec.Descripcion, NºEmpleados = emple.Num_veces, FInicio = er.Fecha_inicio, FFin = er.Fecha_fin, er.Id_erte };

                                var r = consulta2.Distinct().ToList();

                                if (r.Count > 0)
                                {
                                    dgvErtes.DataSource = r;
                                    dgvErtes.Columns[6].Visible = false;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nº Empledaos debe ser numerico");
                        }
                    }
                    else
                    {


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
                else { 
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
    }
}
