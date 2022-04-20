
namespace SG_ERTESheilaDavidMagdaleno
{
    partial class frmEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dniLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label domicilioLabel;
            System.Windows.Forms.Label empresaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleados));
            this.eMPLEADOSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.eMPLEADOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_ertesDataSet = new SG_ERTESheilaDavidMagdaleno.bd_ertesDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.eMPLEADOSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dniMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.emailMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.domicilioTextBox = new System.Windows.Forms.TextBox();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.empresaComboBox = new System.Windows.Forms.ComboBox();
            this.eMPRESASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnFoto = new System.Windows.Forms.Button();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.eMPLEADOSTableAdapter = new SG_ERTESheilaDavidMagdaleno.bd_ertesDataSetTableAdapters.EMPLEADOSTableAdapter();
            this.tableAdapterManager = new SG_ERTESheilaDavidMagdaleno.bd_ertesDataSetTableAdapters.TableAdapterManager();
            this.eMPRESASTableAdapter = new SG_ERTESheilaDavidMagdaleno.bd_ertesDataSetTableAdapters.EMPRESASTableAdapter();
            dniLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            domicilioLabel = new System.Windows.Forms.Label();
            empresaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOSBindingNavigator)).BeginInit();
            this.eMPLEADOSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_ertesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPRESASBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dniLabel
            // 
            dniLabel.AutoSize = true;
            dniLabel.Location = new System.Drawing.Point(12, 45);
            dniLabel.Name = "dniLabel";
            dniLabel.Size = new System.Drawing.Size(26, 13);
            dniLabel.TabIndex = 1;
            dniLabel.Text = "Dni:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(12, 71);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(12, 97);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(52, 13);
            apellidosLabel.TabIndex = 5;
            apellidosLabel.Text = "Apellidos:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(12, 123);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Email:";
            // 
            // domicilioLabel
            // 
            domicilioLabel.AutoSize = true;
            domicilioLabel.Location = new System.Drawing.Point(12, 149);
            domicilioLabel.Name = "domicilioLabel";
            domicilioLabel.Size = new System.Drawing.Size(52, 13);
            domicilioLabel.TabIndex = 9;
            domicilioLabel.Text = "Domicilio:";
            // 
            // empresaLabel
            // 
            empresaLabel.AutoSize = true;
            empresaLabel.Location = new System.Drawing.Point(12, 175);
            empresaLabel.Name = "empresaLabel";
            empresaLabel.Size = new System.Drawing.Size(51, 13);
            empresaLabel.TabIndex = 13;
            empresaLabel.Text = "Empresa:";
            // 
            // eMPLEADOSBindingNavigator
            // 
            this.eMPLEADOSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eMPLEADOSBindingNavigator.BindingSource = this.eMPLEADOSBindingSource;
            this.eMPLEADOSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eMPLEADOSBindingNavigator.DeleteItem = null;
            this.eMPLEADOSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.eMPLEADOSBindingNavigatorSaveItem});
            this.eMPLEADOSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eMPLEADOSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eMPLEADOSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eMPLEADOSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eMPLEADOSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eMPLEADOSBindingNavigator.Name = "eMPLEADOSBindingNavigator";
            this.eMPLEADOSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eMPLEADOSBindingNavigator.Size = new System.Drawing.Size(560, 25);
            this.eMPLEADOSBindingNavigator.TabIndex = 0;
            this.eMPLEADOSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // eMPLEADOSBindingSource
            // 
            this.eMPLEADOSBindingSource.DataMember = "EMPLEADOS";
            this.eMPLEADOSBindingSource.DataSource = this.bd_ertesDataSet;
            // 
            // bd_ertesDataSet
            // 
            this.bd_ertesDataSet.DataSetName = "bd_ertesDataSet";
            this.bd_ertesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // eMPLEADOSBindingNavigatorSaveItem
            // 
            this.eMPLEADOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eMPLEADOSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eMPLEADOSBindingNavigatorSaveItem.Image")));
            this.eMPLEADOSBindingNavigatorSaveItem.Name = "eMPLEADOSBindingNavigatorSaveItem";
            this.eMPLEADOSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.eMPLEADOSBindingNavigatorSaveItem.Text = "Guardar datos";
            this.eMPLEADOSBindingNavigatorSaveItem.Click += new System.EventHandler(this.eMPLEADOSBindingNavigatorSaveItem_Click);
            // 
            // dniMaskedTextBox
            // 
            this.dniMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLEADOSBindingSource, "Dni", true));
            this.dniMaskedTextBox.Location = new System.Drawing.Point(70, 42);
            this.dniMaskedTextBox.Mask = "00000000L";
            this.dniMaskedTextBox.Name = "dniMaskedTextBox";
            this.dniMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.dniMaskedTextBox.TabIndex = 2;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLEADOSBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(70, 68);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(121, 20);
            this.nombreTextBox.TabIndex = 4;
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLEADOSBindingSource, "Apellidos", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(70, 94);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(121, 20);
            this.apellidosTextBox.TabIndex = 6;
            // 
            // emailMaskedTextBox
            // 
            this.emailMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLEADOSBindingSource, "Email", true));
            this.emailMaskedTextBox.Location = new System.Drawing.Point(70, 120);
            this.emailMaskedTextBox.Mask = "LLLLLLLLLL.LLLLLLLLLLLLLLLL";
            this.emailMaskedTextBox.Name = "emailMaskedTextBox";
            this.emailMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.emailMaskedTextBox.TabIndex = 8;
            // 
            // domicilioTextBox
            // 
            this.domicilioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLEADOSBindingSource, "Domicilio", true));
            this.domicilioTextBox.Location = new System.Drawing.Point(70, 146);
            this.domicilioTextBox.Name = "domicilioTextBox";
            this.domicilioTextBox.Size = new System.Drawing.Size(121, 20);
            this.domicilioTextBox.TabIndex = 10;
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eMPLEADOSBindingSource, "Foto", true));
            this.fotoPictureBox.Location = new System.Drawing.Point(239, 42);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(273, 124);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 12;
            this.fotoPictureBox.TabStop = false;
            // 
            // empresaComboBox
            // 
            this.empresaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.eMPLEADOSBindingSource, "Empresa", true));
            this.empresaComboBox.DataSource = this.eMPRESASBindingSource;
            this.empresaComboBox.DisplayMember = "Nombre";
            this.empresaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empresaComboBox.FormattingEnabled = true;
            this.empresaComboBox.Location = new System.Drawing.Point(70, 172);
            this.empresaComboBox.Name = "empresaComboBox";
            this.empresaComboBox.Size = new System.Drawing.Size(121, 21);
            this.empresaComboBox.TabIndex = 14;
            this.empresaComboBox.ValueMember = "Cif";
            // 
            // eMPRESASBindingSource
            // 
            this.eMPRESASBindingSource.DataMember = "EMPRESAS";
            this.eMPRESASBindingSource.DataSource = this.bd_ertesDataSet;
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(280, 169);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(178, 23);
            this.btnFoto.TabIndex = 15;
            this.btnFoto.Text = "CAMBIAR FOTO";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "ofdFoto";
            // 
            // eMPLEADOSTableAdapter
            // 
            this.eMPLEADOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EMPLEADOSTableAdapter = this.eMPLEADOSTableAdapter;
            this.tableAdapterManager.EMPRESASTableAdapter = null;
            this.tableAdapterManager.ERTESTableAdapter = null;
            this.tableAdapterManager.SECTORESTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SG_ERTESheilaDavidMagdaleno.bd_ertesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // eMPRESASTableAdapter
            // 
            this.eMPRESASTableAdapter.ClearBeforeFill = true;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 228);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(dniLabel);
            this.Controls.Add(this.dniMaskedTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(apellidosLabel);
            this.Controls.Add(this.apellidosTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailMaskedTextBox);
            this.Controls.Add(domicilioLabel);
            this.Controls.Add(this.domicilioTextBox);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(empresaLabel);
            this.Controls.Add(this.empresaComboBox);
            this.Controls.Add(this.eMPLEADOSBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmpleados";
            this.Text = "frmEmpleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOSBindingNavigator)).EndInit();
            this.eMPLEADOSBindingNavigator.ResumeLayout(false);
            this.eMPLEADOSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_ertesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPRESASBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bd_ertesDataSet bd_ertesDataSet;
        private System.Windows.Forms.BindingSource eMPLEADOSBindingSource;
        private bd_ertesDataSetTableAdapters.EMPLEADOSTableAdapter eMPLEADOSTableAdapter;
        private bd_ertesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator eMPLEADOSBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton eMPLEADOSBindingNavigatorSaveItem;
        private System.Windows.Forms.MaskedTextBox dniMaskedTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.MaskedTextBox emailMaskedTextBox;
        private System.Windows.Forms.TextBox domicilioTextBox;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.ComboBox empresaComboBox;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.BindingSource eMPRESASBindingSource;
        private bd_ertesDataSetTableAdapters.EMPRESASTableAdapter eMPRESASTableAdapter;
    }
}