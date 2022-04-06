
namespace SG_ERTESheilaDavidMagdaleno
{
    partial class frmErtes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNomEmp = new System.Windows.Forms.TextBox();
            this.txtNumEmple1 = new System.Windows.Forms.TextBox();
            this.txtNomSec = new System.Windows.Forms.TextBox();
            this.txtNumEmple2 = new System.Windows.Forms.TextBox();
            this.dtIniDesde = new System.Windows.Forms.DateTimePicker();
            this.dtFinDesde = new System.Windows.Forms.DateTimePicker();
            this.dtIniHasta = new System.Windows.Forms.DateTimePicker();
            this.dtFinHasta = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvErtes = new System.Windows.Forms.DataGridView();
            this.btnNewErte = new System.Windows.Forms.Button();
            this.btnFinErte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErtes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Empresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nº Empleados Desde:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Inicio Desde:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Fin Desde:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre Sector:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nº Empleados Hasta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha Inicio Hasta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fecha Fin Hasta:";
            // 
            // txtNomEmp
            // 
            this.txtNomEmp.Location = new System.Drawing.Point(149, 32);
            this.txtNomEmp.Name = "txtNomEmp";
            this.txtNomEmp.Size = new System.Drawing.Size(151, 20);
            this.txtNomEmp.TabIndex = 8;
            // 
            // txtNumEmple1
            // 
            this.txtNumEmple1.Location = new System.Drawing.Point(149, 75);
            this.txtNumEmple1.Name = "txtNumEmple1";
            this.txtNumEmple1.Size = new System.Drawing.Size(151, 20);
            this.txtNumEmple1.TabIndex = 9;
            this.txtNumEmple1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumEmple1_KeyPress);
            // 
            // txtNomSec
            // 
            this.txtNomSec.Location = new System.Drawing.Point(440, 32);
            this.txtNomSec.Name = "txtNomSec";
            this.txtNomSec.Size = new System.Drawing.Size(157, 20);
            this.txtNomSec.TabIndex = 10;
            // 
            // txtNumEmple2
            // 
            this.txtNumEmple2.Location = new System.Drawing.Point(440, 75);
            this.txtNumEmple2.Name = "txtNumEmple2";
            this.txtNumEmple2.Size = new System.Drawing.Size(157, 20);
            this.txtNumEmple2.TabIndex = 11;
            this.txtNumEmple2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumEmple2_KeyPress);
            // 
            // dtIniDesde
            // 
            this.dtIniDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtIniDesde.Location = new System.Drawing.Point(149, 113);
            this.dtIniDesde.Name = "dtIniDesde";
            this.dtIniDesde.Size = new System.Drawing.Size(151, 20);
            this.dtIniDesde.TabIndex = 12;
            // 
            // dtFinDesde
            // 
            this.dtFinDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinDesde.Location = new System.Drawing.Point(149, 154);
            this.dtFinDesde.Name = "dtFinDesde";
            this.dtFinDesde.Size = new System.Drawing.Size(151, 20);
            this.dtFinDesde.TabIndex = 13;
            // 
            // dtIniHasta
            // 
            this.dtIniHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtIniHasta.Location = new System.Drawing.Point(440, 113);
            this.dtIniHasta.Name = "dtIniHasta";
            this.dtIniHasta.Size = new System.Drawing.Size(157, 20);
            this.dtIniHasta.TabIndex = 14;
            // 
            // dtFinHasta
            // 
            this.dtFinHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinHasta.Location = new System.Drawing.Point(440, 153);
            this.dtFinHasta.Name = "dtFinHasta";
            this.dtFinHasta.Size = new System.Drawing.Size(157, 20);
            this.dtFinHasta.TabIndex = 15;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(280, 204);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvErtes
            // 
            this.dgvErtes.AllowUserToAddRows = false;
            this.dgvErtes.AllowUserToDeleteRows = false;
            this.dgvErtes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvErtes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErtes.Location = new System.Drawing.Point(12, 245);
            this.dgvErtes.MultiSelect = false;
            this.dgvErtes.Name = "dgvErtes";
            this.dgvErtes.ReadOnly = true;
            this.dgvErtes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvErtes.Size = new System.Drawing.Size(610, 150);
            this.dgvErtes.TabIndex = 17;
            // 
            // btnNewErte
            // 
            this.btnNewErte.Location = new System.Drawing.Point(100, 418);
            this.btnNewErte.Name = "btnNewErte";
            this.btnNewErte.Size = new System.Drawing.Size(95, 23);
            this.btnNewErte.TabIndex = 18;
            this.btnNewErte.Text = "Nuevo ERTE";
            this.btnNewErte.UseVisualStyleBackColor = true;
            this.btnNewErte.Click += new System.EventHandler(this.btnNewErte_Click);
            // 
            // btnFinErte
            // 
            this.btnFinErte.Location = new System.Drawing.Point(431, 418);
            this.btnFinErte.Name = "btnFinErte";
            this.btnFinErte.Size = new System.Drawing.Size(75, 23);
            this.btnFinErte.TabIndex = 19;
            this.btnFinErte.Text = "Fin ERTE";
            this.btnFinErte.UseVisualStyleBackColor = true;
            this.btnFinErte.Click += new System.EventHandler(this.btnFinErte_Click);
            // 
            // frmErtes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 471);
            this.Controls.Add(this.btnFinErte);
            this.Controls.Add(this.btnNewErte);
            this.Controls.Add(this.dgvErtes);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtFinHasta);
            this.Controls.Add(this.dtIniHasta);
            this.Controls.Add(this.dtFinDesde);
            this.Controls.Add(this.dtIniDesde);
            this.Controls.Add(this.txtNumEmple2);
            this.Controls.Add(this.txtNomSec);
            this.Controls.Add(this.txtNumEmple1);
            this.Controls.Add(this.txtNomEmp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmErtes";
            this.Text = "frmErtes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvErtes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNomEmp;
        private System.Windows.Forms.TextBox txtNumEmple1;
        private System.Windows.Forms.TextBox txtNomSec;
        private System.Windows.Forms.TextBox txtNumEmple2;
        private System.Windows.Forms.DateTimePicker dtIniDesde;
        private System.Windows.Forms.DateTimePicker dtFinDesde;
        private System.Windows.Forms.DateTimePicker dtIniHasta;
        private System.Windows.Forms.DateTimePicker dtFinHasta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvErtes;
        private System.Windows.Forms.Button btnNewErte;
        private System.Windows.Forms.Button btnFinErte;
    }
}