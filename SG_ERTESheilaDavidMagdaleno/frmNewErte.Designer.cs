
namespace SG_ERTESheilaDavidMagdaleno
{
    partial class frmNewErte
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
            this.cb_em = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_em
            // 
            this.cb_em.FormattingEnabled = true;
            this.cb_em.Location = new System.Drawing.Point(80, 52);
            this.cb_em.Name = "cb_em";
            this.cb_em.Size = new System.Drawing.Size(121, 21);
            this.cb_em.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empresa:";
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(26, 108);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(75, 23);
            this.btnA.TabIndex = 3;
            this.btnA.Text = "ACEPTAR";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(126, 108);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 23);
            this.btnC.TabIndex = 4;
            this.btnC.Text = "CANCELAR";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // frmNewErte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 186);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_em);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNewErte";
            this.Text = "frmNewErte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_em;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnC;
    }
}