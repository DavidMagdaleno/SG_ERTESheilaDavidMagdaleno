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
    public partial class frmInformes : Form
    {
        public frmInformes()
        {
            InitializeComponent();
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            using (bd_ertesEntities objBD = new bd_ertesEntities())
            {
                var consulAux = from er in objBD.ERTES
                                select er.Empresa;

                var qConsultaAgrup = from emple in objBD.EMPLEADOS
                                     group emple by emple.Empresa into grupo
                                     select new
                                     {
                                         empr = grupo.Key,
                                         Num_veces = grupo.Count()
                                     };
                var maxValor = qConsultaAgrup.Max(x => x.Num_veces);
                var subConsulta = qConsultaAgrup.Where(x => x.Num_veces == maxValor);

                var consulta4 = from empleado in subConsulta.ToList()
                                from emp in objBD.EMPRESAS
                                from er in consulAux
                                where empleado.empr == emp.Cif && consulAux.Contains(emp.Cif)
                                select new
                                {
                                    emp.Nombre,
                                    emp.Cif,
                                };

                dgvInformes.DataSource = consulta4.Distinct().ToList();
            }
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            using (bd_ertesEntities objBD = new bd_ertesEntities())
            {
                var qConsultaAgrup = from er in objBD.ERTES
                                     group er by er.Empresa into grupo
                                     select new
                                     {
                                         empr = grupo.Key,
                                         Num_veces = grupo.Count()
                                     };
                var maxValor = qConsultaAgrup.Max(x => x.Num_veces);
                var subConsulta = qConsultaAgrup.Where(x => x.Num_veces == maxValor);

                var consulta4 = from er in subConsulta.ToList()
                                from emp in objBD.EMPRESAS
                                where er.empr == emp.Cif
                                select new
                                {
                                    emp.Nombre,
                                    emp.Cif,
                                };

                dgvInformes.DataSource = consulta4.Distinct().ToList();
            }
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            using (bd_ertesEntities objBD = new bd_ertesEntities())
            {
                var qConsultaAgrup = from er in objBD.ERTES
                                     from emp in objBD.EMPRESAS
                                     where er.Fecha_fin==null && emp.Cif==er.Empresa
                                     group emp by emp.Sector into grupo
                                     select new
                                     {
                                         empr = grupo.Key,
                                         Num_veces = grupo.Count()
                                     };
                var maxValor = qConsultaAgrup.Max(x => x.Num_veces);
                var subConsulta = qConsultaAgrup.Where(x => x.Num_veces == maxValor);

                var consulta4 = from emp in subConsulta.ToList()
                                from sec in objBD.SECTORES
                                where emp.empr == sec.Id_sector 
                                select new
                                {
                                    sec.Descripcion
                                };

                dgvInformes.DataSource = consulta4.Distinct().ToList();
            }
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            using (bd_ertesEntities objBD = new bd_ertesEntities())
            {
                var consul = from ert in objBD.ERTES
                             select ert;
                var minValor = consul.Min(x => x.Fecha_inicio);
                var subConsulta = consul.Where(x => x.Fecha_inicio == minValor);


                var Consulta = from er in subConsulta
                               from emple in objBD.EMPLEADOS
                               from empre in objBD.EMPRESAS
                               where emple.Empresa == empre.Cif && empre.Cif == er.Empresa
                               select new
                               {
                                   Empresa= empre.Nombre,
                                   CIF = empre.Cif
                                };
       
                dgvInformes.DataSource = Consulta.Distinct().ToList();
            }
        }

        private void btnC5_Click(object sender, EventArgs e)
        {
            using (bd_ertesEntities objBD = new bd_ertesEntities())
            {
                var qConsultaAgrup = from er in objBD.ERTES
                                     from emple in objBD.EMPLEADOS
                                     from empre in objBD.EMPRESAS
                                     where er.Fecha_fin==null && emple.Empresa==empre.Cif && empre.Cif==er.Empresa
                                     group emple by emple.Empresa into grupo
                                     select new
                                     {
                                         empr = grupo.Key,
                                         Num_veces = grupo.Count()
                                     };
                var maxValor = qConsultaAgrup.Max(x => x.Num_veces);
                var subConsulta = qConsultaAgrup.Where(x => x.Num_veces == maxValor);

                var consulta4 = from ew in subConsulta.ToList()
                                select new
                                {
                                    ew.Num_veces
                                };

                dgvInformes.DataSource = consulta4.Distinct().ToList();
            }
        }
    }
}
