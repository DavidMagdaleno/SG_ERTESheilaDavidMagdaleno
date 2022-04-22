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
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void eMPLEADOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (dniMaskedTextBox.Text.Trim() != "" && nombreTextBox.Text.Trim() != "" && apellidosTextBox.Text.Trim() != "" && emailMaskedTextBox.Text.Trim() != "" && domicilioTextBox.Text.Trim() != "" && empresaComboBox.SelectedIndex != -1)
            {
                DialogResult resp = new DialogResult();
                resp = MessageBox.Show("Estas seguro de quieres insertar el Empleado", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                if (resp == DialogResult.Yes)
                {
                    try
                    {
                        dniMaskedTextBox.Text = dniMaskedTextBox.Text.Trim();
                        nombreTextBox.Text = nombreTextBox.Text.Trim();
                        apellidosTextBox.Text = apellidosTextBox.Text.Trim();
                        emailMaskedTextBox.Text = emailMaskedTextBox.Text.Trim();
                        domicilioTextBox.Text = domicilioTextBox.Text.Trim();
                        this.Validate();
                        this.eMPLEADOSBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.bd_ertesDataSet);
                        bindingNavigatorAddNewItem.Enabled = true;
                    }
                    catch (Exception x)
                    {
                        if (nombreTextBox.Text.Trim() != "" && apellidosTextBox.Text.Trim() != "" && emailMaskedTextBox.Text.Trim() != "" && domicilioTextBox.Text.Trim() != "" && empresaComboBox.SelectedIndex != -1)
                        {
                            MessageBox.Show("Revisa el Dni del Empleado");
                            dniMaskedTextBox.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Hay campos en blanco");
                        }
                    }
                }
            }
            else { MessageBox.Show("Hay campos en blanco"); }
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd_ertesDataSet.EMPRESAS' Puede moverla o quitarla según sea necesario.
            this.eMPRESASTableAdapter.Fill(this.bd_ertesDataSet.EMPRESAS);
            // TODO: esta línea de código carga datos en la tabla 'bd_ertesDataSet.EMPLEADOS' Puede moverla o quitarla según sea necesario.
            this.eMPLEADOSTableAdapter.Fill(this.bd_ertesDataSet.EMPLEADOS);
            

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            //Suponemos que ofdExaminar es un OpenFileDialog incorporado al formulario
            ofdFoto.Filter = "image files|*.jpg;*.png;*.gif;*.ico;.*;";

            DialogResult dres = ofdFoto.ShowDialog();

            if (dres == DialogResult.Abort)
                return;
            if (dres == DialogResult.Cancel)
                return;

            //para guardar la ruta al fichero con la imagen en un TextBox (por si se quiere mostrar)
            //txtRutaFichero.Text = ofdExaminar.FileName;

            //Se muestra la imagen en el PictureBox directamente de la ruta devuelta por el OpenFileDialog
            fotoPictureBox.Image = Image.FromFile(ofdFoto.FileName);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = true;
            DialogResult resp = new DialogResult();
            resp = MessageBox.Show("Estas seguro de quieres eliminar el Empleado", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (resp == DialogResult.Yes)
            {
                bd_ertesDataSetTableAdapters.EMPLEADOSTableAdapter tbres = new bd_ertesDataSetTableAdapters.EMPLEADOSTableAdapter();
                var aux=tbres.FillByDNI(bd_ertesDataSet.EMPLEADOS, dniMaskedTextBox.Text);
                if (aux > 0)
                {
                    tbres.DeleteQueryEmpleados(dniMaskedTextBox.Text);
                    this.eMPRESASTableAdapter.Fill(this.bd_ertesDataSet.EMPRESAS);
                    this.eMPLEADOSTableAdapter.Fill(this.bd_ertesDataSet.EMPLEADOS);
                }
                else {
                    MessageBox.Show("El Empleado no existe");
                    this.eMPRESASTableAdapter.Fill(this.bd_ertesDataSet.EMPRESAS);
                    this.eMPLEADOSTableAdapter.Fill(this.bd_ertesDataSet.EMPLEADOS);
                }
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorMovePreviousItem.Enabled = false;
            bindingNavigatorMoveFirstItem.Enabled = false;
            bindingNavigatorAddNewItem.Enabled = false;
        }
    }
}
