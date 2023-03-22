using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MigradorRP
{
    public partial class frmConfigImportacao : Form
    {
        private frmMain pai = null;
        public bool canCloseApp = false;
        private bool confirmaAlterarModo = false;
        private string[] alterados= { };
        public frmConfigImportacao(frmMain pai = null)
        {
            InitializeComponent();
            this.pai = pai;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(188, 75, 81);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
        }

        private void frmConfigImportacao_Load(object sender, EventArgs e)
        {
            if (canCloseApp)
            {
                this.Size = new Size(this.Size.Width, 200);
                pnlConfigOptions.Visible = false;
            }
            cfgImpQtd.Checked= ConfigReader.GetConfigValue("importa_quantidade") == "true";

            if(ConfigReader.tipoImportacao == null)
            {
                cboEntrada.SelectedIndex= 0;
                cboSistema.SelectedIndex = 0;
            }
            else
            {
                cboEntrada.SelectedItem = ConfigReader.tipoImportacao.ToString();
                cboSistema.SelectedItem = ConfigReader.sistema.ToString();
            }


            btnCancelCLose.Location = new Point(3, this.Size.Height - btnCancelCLose.Size.Height -5);
            btSaveConfig.Location = new Point(this.Size.Width - btSaveConfig.Size.Width - 5, this.Size.Height - btSaveConfig.Size.Height -5);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseConfig();
        }

        private void cfgImpQtd_Change(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            ConfigReader.SetConfigValue("importa_quantidade", chk.Checked ? "true": "false");
        }

        public void CloseConfig()
        {
            if(canCloseApp)
            {
                Application.Exit();
                return;
            }

            ConfigReader.ReloadConfig();
            this.Dispose(true);
        }

        private void btnCancelCLose_Click(object sender, EventArgs e)
        {
            CloseConfig();
        }

        private void btSaveConfig_Click(object sender, EventArgs e)
        {
            

            if(confirmaAlterarModo)
            {
                if(MessageBox.Show("Deseja alterar a configuração de " + string.Join( " e ", alterados) + "?", pai.titulo, MessageBoxButtons.YesNo,MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
            }

            ConfigReader.SaveConfig();
            ConfigReader.sistema = cboSistema.SelectedItem.ToString();
            ConfigReader.tipoImportacao = cboEntrada.SelectedItem.ToString();

            this.Dispose();
        }

        private void cboEntrada_SelectedValueChanged(object sender, EventArgs e)
        {
            if(ConfigReader.tipoImportacao != null)
            {
                string searchItem = "entrada de dados";
                if (ConfigReader.tipoImportacao != cboEntrada.SelectedItem.ToString())
                {
                    confirmaAlterarModo = true;

                    Array.Resize(ref alterados, alterados.Length + 1);
                    alterados[alterados.Length - 1] = searchItem;
                }
                else
                {
                    int index = Array.FindIndex(alterados, x => x.Contains(searchItem));
                    if (index != -1)
                    {
                        string[] newArr = new string[alterados.Length - 1];
                        Array.Copy(alterados, 0, newArr, 0, index);
                        Array.Copy(alterados, index + 1, newArr, index, alterados.Length - index - 1);
                        alterados = newArr;
                    }
                }
            }
        }

        private void cboSistema_SelectedValueChanged(object sender, EventArgs e)
        {

            if (ConfigReader.sistema != null)
            {
                string searchItem = "sistema";
                if (ConfigReader.sistema != cboSistema.SelectedItem.ToString())
                {
                    confirmaAlterarModo = true;
                    
                    Array.Resize(ref alterados, alterados.Length + 1);
                    alterados[alterados.Length - 1] = searchItem;
                }
                else
                {
                    int index = Array.FindIndex(alterados, x => x.Contains(searchItem));
                    if (index != -1)
                    {
                        string[] newArr = new string[alterados.Length - 1];
                        Array.Copy(alterados, 0, newArr, 0, index);
                        Array.Copy(alterados, index + 1, newArr, index, alterados.Length - index - 1);
                        alterados = newArr;
                    }
                }
            }

            if(alterados.Length == 0)
            {
                confirmaAlterarModo = false;
            }
        }

        private void pnlConfigOptions_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
