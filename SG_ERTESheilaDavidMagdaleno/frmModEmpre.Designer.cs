
namespace SG_ERTESheilaDavidMagdaleno
{
    partial class frmModEmpre
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
            this.txtCif = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtDom = new System.Windows.Forms.TextBox();
            this.cbSec = new System.Windows.Forms.ComboBox();
            this.btnAcep = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CIF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DOMICILIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "SECTOR";
            // 
            // txtCif
            // 
            this.txtCif.Location = new System.Drawing.Point(85, 27);
            this.txtCif.Name = "txtCif";
            this.txtCif.ReadOnly = true;
            this.txtCif.Size = new System.Drawing.Size(121, 20);
            this.txtCif.TabIndex = 4;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(85, 68);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(121, 20);
            this.txtNom.TabIndex = 5;
            // 
            // txtDom
            // 
            this.txtDom.Location = new System.Drawing.Point(85, 107);
            this.txtDom.Name = "txtDom";
            this.txtDom.Size = new System.Drawing.Size(121, 20);
            this.txtDom.TabIndex = 6;
            // 
            // cbSec
            // 
            this.cbSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSec.FormattingEnabled = true;
            this.cbSec.Location = new System.Drawing.Point(85, 146);
            this.cbSec.Name = "cbSec";
            this.cbSec.Size = new System.Drawing.Size(121, 21);
            this.cbSec.TabIndex = 7;
            // 
            // btnAcep
            // 
            this.btnAcep.Location = new System.Drawing.Point(22, 204);
            this.btnAcep.Name = "btnAcep";
            this.btnAcep.Size = new System.Drawing.Size(75, 23);
            this.btnAcep.TabIndex = 8;
            this.btnAcep.Text = "ACEPTAR";
            this.btnAcep.UseVisualStyleBackColor = true;
            this.btnAcep.Click += new System.EventHandler(this.btnAcep_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(152, 204);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "VOLVER";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmModEmpre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 248);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAcep);
            this.Controls.Add(this.cbSec);
            this.Controls.Add(this.txtDom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtCif);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModEmpre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModEmpre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCif;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtDom;
        private System.Windows.Forms.ComboBox cbSec;
        private System.Windows.Forms.Button btnAcep;
        private System.Windows.Forms.Button btnCancel;
    }
}