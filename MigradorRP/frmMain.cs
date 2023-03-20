using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Reflection;
using System.Data.Odbc;
using System.IO;

namespace MigradorRP
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            this.Paint += new PaintEventHandler(Element_Paint);

            try
            {
                ConfigReader.SetFilePath(pathConfig);
                config = ConfigReader.config();

                lblTopBar.Text = titulo.ToString() + " | MigradorRP";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public static Dictionary<string, string> config;
        public Button activeButton;
        public static string caminho                    = Path.GetDirectoryName(Application.ExecutablePath);
        public static string fileConfig                 = "config.conf";
        public static string pathConfig                 = Path.Combine( caminho , fileConfig);
        public string titulo                            = ConfigurationManager.AppSettings["appTitle"];
        public static string testeTxt                   = "";

        private void Element_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath forma = new GraphicsPath();
            forma.StartFigure();
       
            forma.AddArc(new Rectangle(0, 0, 20, 20), 180, 90);
            forma.AddLine(20, 0, this.Width - 20, 0);
            forma.AddArc(new Rectangle(this.Width - 20, 0, 20, 20), -90, 90);
            forma.AddLine(this.Width, 20, this.Width, this.Height - 20);
            forma.AddArc(new Rectangle(this.Width - 20, this.Height - 20, 20, 20), 0, 90);
            forma.AddLine(this.Width - 20, this.Height, 20, this.Height);
            forma.AddArc(new Rectangle(0, this.Height - 20, 20, 20), 90, 90);
            forma.CloseFigure();
            this.Region = new Region(forma);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("User32.dll")]
        private static extern IntPtr GetWindowDC(IntPtr hWnd);

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            const int WM_NCPAINT = 0x85;
            if (m.Msg == WM_NCPAINT)
            {
                IntPtr hdc = GetWindowDC(m.HWnd);
                if ((int)hdc != 0)
                {
                    Graphics g = Graphics.FromHdc(hdc);
                    g.FillRectangle(Brushes.Green, new Rectangle(0, 0, 4800, 23));
                    g.Flush();
                    ReleaseDC(m.HWnd, hdc);
                }
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            string textFilter = "Arquivos Excel | *.xls; *.xlsx";
            string titleDialog = "Selecione uma planilha para importar no sistema";

            fileDialogProd.Filter = textFilter;
            fileDialogProd.Title = titleDialog;

            fileDialogClient.Filter = textFilter;
            fileDialogClient.Title = titleDialog;

            fileDialogForn.Filter = textFilter;
            fileDialogForn.Title = titleDialog;


            frmConfig frmConfig = new frmConfig();
            frmConfig.Pai = this;
            frmConfig.canCloseApp = true;
            frmConfig.ShowDialog();
            this.Visible = false;
            tmrBorda.Interval = 1;
        }

        public void moverForm()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblMin_MouseEnter(object sender, EventArgs e)
        {
            lblMin.BackColor = Color.FromArgb(54,54,54);
        }

        private void lblMin_MouseLeave(object sender, EventArgs e)
        {
            lblMin.BackColor = Color.Transparent;
        }

        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            lblClose.BackColor = Color.FromArgb(188, 75, 81);
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.BackColor = Color.Transparent;
        }

        private void lblTopBar_MouseMove(object sender, MouseEventArgs e)
        {
            moverForm();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSetSystem_Click(object sender, EventArgs e)
        {
            tmrBorda.Enabled = true;
            //(new frmConfig()).ShowDialog();
        }

        public void ReceiverData(string dados)
        {
            txtCaminho.Text = dados;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int toPosition = activeButton.Left - pnlBorda.Left;
            bool type = toPosition > 0 ? true : false;

            if (toPosition != 0)
            {
                if (type)
                {
                    pnlBorda.Left += 15;
                }
                else
                {
                    pnlBorda.Left -= 15;
                }
            }
            else
            {
                tmrBorda.Stop();
            }
        }

        private void BtnFileProd_Click(object sender, EventArgs e)
        {
            if(fileDialogProd.ShowDialog() == DialogResult.OK)
            {
                BtnFileProd.Text = fileDialogProd.SafeFileName;
            }
            else
            {
                BtnFileProd.Text = "Produtos...";
                fileDialogProd.FileName = "";
            }
            activeButton = BtnFileProd;
            tmrBorda.Enabled = true;
        }

        private void btnFileClient_Click(object sender, EventArgs e)
        {
            if (fileDialogClient.ShowDialog() == DialogResult.OK)
            {
                btnFileClient.Text = fileDialogClient.SafeFileName;
            }
            else
            {
                btnFileClient.Text          = "Clientes...";
                fileDialogClient.FileName   = "";
            }
            activeButton = btnFileClient;
            tmrBorda.Enabled = true;
        }

        private void btnFileFornecedor_Click(object sender, EventArgs e)
        {
            if (fileDialogForn.ShowDialog() == DialogResult.OK)
            {
                btnFileFornecedor.Text = fileDialogForn.SafeFileName;
            }
            else
            {
                btnFileFornecedor.Text = "Fornecedores...";
                fileDialogForn.FileName = "";
            }
            activeButton = btnFileFornecedor;
            tmrBorda.Enabled = true;
        }

        private void btnCancelFiles_Click(object sender, EventArgs e)
        {
            try
            {

                BtnFileProd.Enabled = true;
                BtnFileProd.Text = "Produtos...";
                fileDialogProd.FileName = "";

                btnFileClient.Enabled = true;
                btnFileClient.Text = "Clientes...";
                fileDialogClient.FileName = "";

                btnFileFornecedor.Enabled = true;
                btnFileFornecedor.Text = "Fornecedores...";
                fileDialogForn.FileName = "";
            }catch(Exception error) {
                Util.ErrorMessage(error.Message);
            }
        }

        private void btnValidateFiles_Click(object sender, EventArgs e)
        {
            try
            {
                if (fileDialogProd.FileName == "" && fileDialogClient.FileName == "" && fileDialogForn.FileName == "")
                {
                    throw new Exception("Nenhum arquivo foi selecionado");
                }

                BtnFileProd.Enabled = false;
                btnFileClient.Enabled = false;
                btnFileFornecedor.Enabled = false;

                string abrir = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='{0}';Extended Properties='Excel 12.0 Xml;HDR=YES;ReadOnly=True';", fileDialogProd.FileName);

                OleDbConnection con = new OleDbConnection(abrir);
                con.Open();
                DataTable dt = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                int i = 0;

                MessageBox.Show(dt.Rows[0]["TABLE_NAME"].ToString());

                //foreach (DataRow row in dt.Rows)
                //{
                //    cboFor.Items.Add(row["TABLE_NAME"].ToString().Replace("$", "").Replace("'", ""));
                //    i++;
                //}

                con.Close();
            }
            catch(Exception err)
            {
                Util.ErrorMessage(err.Message);
            }
            
        }
    }
}
