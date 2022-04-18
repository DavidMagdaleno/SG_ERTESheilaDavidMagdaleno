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
    public partial class frmEmpresas : Form
    {
        public frmEmpresas()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void frmEmpresas_Load(object sender, EventArgs e)
        {

        }

        private void CargarDatos() {
            using (bd_ertesEntities objBD = new bd_ertesEntities())
            {
                var consulta2 = from emp in objBD.EMPRESAS
                                from sec in objBD.SECTORES
                                where emp.Sector==sec.Id_sector
                                orderby emp.Nombre
                                select new { emp.Nombre,sec.Descripcion,emp.Cif,sec.Id_sector};

                var r = consulta2.Distinct().ToList();

                if (r.Count > 0)
                {
                    dgvEmpresas.DataSource = r;
                }
                dgvEmpresas.Columns[3].Visible = false;
            }
        }

        private void dgvEmpresas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmModEmpre f1 = new frmModEmpre(dgvEmpresas.SelectedRows[0].Cells[2].Value.ToString(), int.Parse(dgvEmpresas.SelectedRows[0].Cells[3].Value.ToString()));
            f1.ShowDialog();
        }

        private void btnModEmp_Click(object sender, EventArgs e)
        {
            frmModEmpre f1 = new frmModEmpre(dgvEmpresas.SelectedRows[0].Cells[2].Value.ToString(), int.Parse(dgvEmpresas.SelectedRows[0].Cells[3].Value.ToString()));
            //f1.ShowDialog();
            DialogResult dres = f1.ShowDialog();
            if (dres == DialogResult.Cancel)
            {
                CargarDatos();
            }
        }

        private void btnEli_Click(object sender, EventArgs e)
        {
            if (dgvEmpresas.SelectedRows.Count > 0) {
                using (bd_ertesEntities objBD = new bd_ertesEntities())
                {
                    EMPRESAS objEmp = objBD.EMPRESAS.Find(dgvEmpresas.SelectedRows[0].Cells[2].Value);
                    if (objEmp != null)
                    {
                        if (objEmp.EMPLEADOS.Count > 0)
                        {
                            MessageBox.Show("La empresa tiene empleados");
                        }
                        else {
                            if (objEmp.ERTES.Count > 0) {
                                MessageBox.Show("La empresa tiene ertes pendientes");
                            }
                            else
                            {
                                DialogResult resp = new DialogResult();
                                resp = MessageBox.Show("Estas seguro de quieres eliminar la empresa", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                                if (resp == DialogResult.Yes)
                                {
                                    //se elemina el objeto de la tabla, para quitarlo como registro
                                    objBD.EMPRESAS.Remove(objEmp);
                                    //se guardan los cambios
                                    objBD.SaveChanges();
                                    MessageBox.Show("Eliminado");
                                    CargarDatos();
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("La empresa ya no existe en la BD");
                    }
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado a ninguna empresa");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmNewEmpre m = new frmNewEmpre();
            DialogResult dres = m.ShowDialog();
            if (dres == DialogResult.Cancel)
            {
                CargarDatos();
            }
        }
    }
}
