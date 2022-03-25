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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iNFORMESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (MdiChildren[0].Name != "frmInformes")
                {
                    DialogResult rs = MessageBox.Show("¿ Deseas cerrar las " + MdiChildren[0].Name + "?", "!ATENCION¡", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        MdiChildren[0].Close();
                        frmInformes f1 = new frmInformes();
                        f1.MdiParent = this;
                        f1.Dock = DockStyle.Fill;
                        f1.Show();
                    }
                }
            }
            else
            {
                frmInformes f1 = new frmInformes();
                f1.MdiParent = this;
                f1.Dock = DockStyle.Fill;
                f1.Show();
            }
        }

        private void eRTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (MdiChildren[0].Name != "frmErtes")
                {
                    DialogResult rs = MessageBox.Show("¿ Deseas cerrar las " + MdiChildren[0].Name + "?", "!ATENCION¡", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        MdiChildren[0].Close();
                        frmErtes f1 = new frmErtes();
                        f1.MdiParent = this;
                        f1.Dock = DockStyle.Fill;
                        f1.Show();
                    }
                }
            }
            else
            {
                frmErtes f1 = new frmErtes();
                f1.MdiParent = this;
                f1.Dock = DockStyle.Fill;
                f1.Show();
            }
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (MdiChildren[0].Name != "frmEmpresas")
                {
                    DialogResult rs = MessageBox.Show("¿ Deseas cerrar las " + MdiChildren[0].Name + "?", "!ATENCION¡", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        MdiChildren[0].Close();
                        frmEmpresas f1 = new frmEmpresas();
                        f1.MdiParent = this;
                        f1.Dock = DockStyle.Fill;
                        f1.Show();
                    }
                }
            }
            else
            {
                frmEmpresas f1 = new frmEmpresas();
                f1.MdiParent = this;
                f1.Dock = DockStyle.Fill;
                f1.Show();
            }
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (MdiChildren[0].Name != "frmEmpleados")
                {
                    DialogResult rs = MessageBox.Show("¿ Deseas cerrar las " + MdiChildren[0].Name + "?", "!ATENCION¡", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        MdiChildren[0].Close();
                        frmEmpleados f1 = new frmEmpleados();
                        f1.MdiParent = this;
                        f1.Dock = DockStyle.Fill;
                        f1.Show();
                    }
                }
            }
            else
            {
                frmEmpleados f1 = new frmEmpleados();
                f1.MdiParent = this;
                f1.Dock = DockStyle.Fill;
                f1.Show();
            }
        }
    }
}
