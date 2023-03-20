using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MigradorRP
{
    public partial class frmConfig : Form
    {
        private frmMain pai = null;
        public bool canCloseApp = false;
        public frmMain Pai
        {
            get { return pai; }
            set { pai = value; }
        }

        public frmConfig()
        {
            InitializeComponent();
        }

        private void CloseForm()
        {
            if (canCloseApp)
            {
                Application.Exit();
            }
            else
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            cboEntrada.SelectedIndex= 0;
            cboSistema.SelectedIndex= 0;
        }
        
        private void btnConfirma_Click(object sender, EventArgs e)
        {
            pai.Visible = true;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (this.canCloseApp)
            {
                Application.Exit();
            }
        }
    }
}
