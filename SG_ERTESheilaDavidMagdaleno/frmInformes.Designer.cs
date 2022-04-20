
namespace SG_ERTESheilaDavidMagdaleno
{
    partial class frmInformes
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
            this.btnC1 = new System.Windows.Forms.Button();
            this.btnC2 = new System.Windows.Forms.Button();
            this.btnC3 = new System.Windows.Forms.Button();
            this.btnC4 = new System.Windows.Forms.Button();
            this.btnC5 = new System.Windows.Forms.Button();
            this.dgvInformes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnC1
            // 
            this.btnC1.Location = new System.Drawing.Point(23, 50);
            this.btnC1.Name = "btnC1";
            this.btnC1.Size = new System.Drawing.Size(75, 23);
            this.btnC1.TabIndex = 0;
            this.btnC1.Text = "Consulta 1";
            this.btnC1.UseVisualStyleBackColor = true;
            this.btnC1.Click += new System.EventHandler(this.btnC1_Click);
            // 
            // btnC2
            // 
            this.btnC2.Location = new System.Drawing.Point(126, 50);
            this.btnC2.Name = "btnC2";
            this.btnC2.Size = new System.Drawing.Size(75, 23);
            this.btnC2.TabIndex = 1;
            this.btnC2.Text = "Consulta 2";
            this.btnC2.UseVisualStyleBackColor = true;
            this.btnC2.Click += new System.EventHandler(this.btnC2_Click);
            // 
            // btnC3
            // 
            this.btnC3.Location = new System.Drawing.Point(238, 50);
            this.btnC3.Name = "btnC3";
            this.btnC3.Size = new System.Drawing.Size(75, 23);
            this.btnC3.TabIndex = 2;
            this.btnC3.Text = "Consulta 3";
            this.btnC3.UseVisualStyleBackColor = true;
            this.btnC3.Click += new System.EventHandler(this.btnC3_Click);
            // 
            // btnC4
            // 
            this.btnC4.Location = new System.Drawing.Point(345, 50);
            this.btnC4.Name = "btnC4";
            this.btnC4.Size = new System.Drawing.Size(75, 23);
            this.btnC4.TabIndex = 3;
            this.btnC4.Text = "Consulta 4";
            this.btnC4.UseVisualStyleBackColor = true;
            this.btnC4.Click += new System.EventHandler(this.btnC4_Click);
            // 
            // btnC5
            // 
            this.btnC5.Location = new System.Drawing.Point(455, 50);
            this.btnC5.Name = "btnC5";
            this.btnC5.Size = new System.Drawing.Size(75, 23);
            this.btnC5.TabIndex = 4;
            this.btnC5.Text = "Consulta 5";
            this.btnC5.UseVisualStyleBackColor = true;
            this.btnC5.Click += new System.EventHandler(this.btnC5_Click);
            // 
            // dgvInformes
            // 
            this.dgvInformes.AllowUserToAddRows = false;
            this.dgvInformes.AllowUserToDeleteRows = false;
            this.dgvInformes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInformes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformes.Location = new System.Drawing.Point(13, 106);
            this.dgvInformes.MultiSelect = false;
            this.dgvInformes.Name = "dgvInformes";
            this.dgvInformes.ReadOnly = true;
            this.dgvInformes.Size = new System.Drawing.Size(527, 161);
            this.dgvInformes.TabIndex = 5;
            // 
            // frmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 300);
            this.Controls.Add(this.dgvInformes);
            this.Controls.Add(this.btnC5);
            this.Controls.Add(this.btnC4);
            this.Controls.Add(this.btnC3);
            this.Controls.Add(this.btnC2);
            this.Controls.Add(this.btnC1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInformes";
            this.Text = "frmInformes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnC1;
        private System.Windows.Forms.Button btnC2;
        private System.Windows.Forms.Button btnC3;
        private System.Windows.Forms.Button btnC4;
        private System.Windows.Forms.Button btnC5;
        private System.Windows.Forms.DataGridView dgvInformes;
    }
}