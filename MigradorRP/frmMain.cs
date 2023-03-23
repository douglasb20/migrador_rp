using FontAwesome.Sharp;
using MigradorRP.libs;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Linq;

namespace MigradorRP
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            try
            {
                InitializeComponent();
                this.Paint += new PaintEventHandler(Element_Paint);
                tmrBorda.Tick += new EventHandler(DesignAndActions.timer1_Tick);

                ConfigReader.LoadConfig(pathConfig);

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

            Console.WriteLine("Oi");

            ToolTip toolBtValidate = new ToolTip();
            toolBtValidate.SetToolTip(btnValidateFiles, "Validar planilhas");
            toolBtValidate.SetToolTip(btnCancelFiles, "Remover planilhas");
            toolBtValidate.SetToolTip(btnSetSystem, "Configurações do migrador");
            toolBtValidate.SetToolTip(BtnFileProd, "Escolha uma planilha de produtos");
            toolBtValidate.SetToolTip(btnFileClient, "Escolha uma planilha de clientes");
            toolBtValidate.SetToolTip(btnFileFornecedor, "Escolha uma planilha de fornecedores");
            toolBtValidate.InitialDelay = 250;
            
            lblTabClient.MouseEnter += new EventHandler(DesignAndActions.lblMouseEnter);
            lblTabClient.MouseLeave += new EventHandler(DesignAndActions.lblMouseOut);

            lblTabProd.MouseEnter += new EventHandler(DesignAndActions.lblMouseEnter);
            lblTabProd.MouseLeave += new EventHandler(DesignAndActions.lblMouseOut);

            lblTabForn.MouseEnter += new EventHandler(DesignAndActions.lblMouseEnter);
            lblTabForn.MouseLeave += new EventHandler(DesignAndActions.lblMouseOut);

            fileDialogProd.Filter = textFilter;
            fileDialogProd.Title = titleDialog;

            fileDialogClient.Filter = textFilter;
            fileDialogClient.Title = titleDialog;

            fileDialogForn.Filter = textFilter;
            fileDialogForn.Title = titleDialog;

            btnCancelFiles.Enabled = false;
            btnCancelFiles.IconColor = Color.FromArgb(24, 24, 24);

            frmConfigImportacao frmConfig = new frmConfigImportacao(this);
            frmConfig.canCloseApp = true;
            frmConfig.ShowDialog();
            this.Hide();

            tmrBorda.Interval = 1;

            dtGridProdutos.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dtGridProdutos_DataBindingComplete);

        }

        public void moverForm()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void dtGridProdutos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            MessageBox.Show("Dados carregados com sucesso!");
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void BtnFileProd_Click(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;

            if (fileDialogProd.ShowDialog() == DialogResult.OK)
            {
                btn.Text = fileDialogProd.SafeFileName;
                btn.IconChar = IconChar.FileCircleCheck;
            }
            else
            {
                btn.Text = "Produtos...";
                btn.IconChar = IconChar.FileArrowUp;
                fileDialogProd.FileName = "";
            }
            
        }

        private void btnFileClient_Click(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;

            if (fileDialogClient.ShowDialog() == DialogResult.OK)
            {
                btn.Text = fileDialogClient.SafeFileName;
                btn.IconChar = IconChar.FileCircleCheck;
            }
            else
            {
                btn.Text          = "Clientes...";
                btn.IconChar = IconChar.FileArrowUp;
                fileDialogClient.FileName   = "";
            }

        }

        private void btnFileFornecedor_Click(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;

            if (fileDialogForn.ShowDialog() == DialogResult.OK)
            {
                btn.Text = fileDialogForn.SafeFileName;
                btn.IconChar = IconChar.FileCircleCheck;
            }
            else
            {
                btn.Text = "Fornecedores...";
                btn.IconChar = IconChar.FileArrowUp;
                fileDialogForn.FileName = "";
            }

        }

        private void btnCancelFiles_Click(object sender, EventArgs e)
        {
            
            try
            {

                BtnFileProd.Enabled = true;
                BtnFileProd.Text = "Produtos";
                fileDialogProd.FileName = "";
                BtnFileProd.IconChar = IconChar.FileArrowUp;

                btnFileClient.Enabled = true;
                btnFileClient.Text = "Clientes";
                btnFileClient.IconChar = IconChar.FileArrowUp;
                fileDialogClient.FileName = "";

                btnFileFornecedor.Enabled = true;
                btnFileFornecedor.Text = "Fornecedores";
                btnFileFornecedor.IconChar = IconChar.FileArrowUp;
                fileDialogForn.FileName = "";

                btnValidateFiles.Enabled = true;
                btnValidateFiles.IconColor = Color.White;

                btnCancelFiles.Enabled = false;
                btnCancelFiles.IconColor = Color.FromArgb(24, 24, 24);

            }
            catch(Exception error) {
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

                btnValidateFiles.Enabled = false;
                btnValidateFiles.IconColor = Color.FromArgb(24, 24, 24);

                BtnFileProd.Enabled = false;
                btnFileClient.Enabled = false;
                btnFileFornecedor.Enabled = false;

                btnCancelFiles.Enabled = true;
                btnCancelFiles.IconColor = Color.White;

                string abrir = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='{0}';Extended Properties='Excel 12.0 Xml;HDR=YES;ReadOnly=True';", fileDialogProd.FileName);

                OleDbConnection con = new OleDbConnection(abrir);
                con.Open();
                DataTable dt = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);


                string planilha = dt.Rows[0]["TABLE_NAME"].ToString();
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM [" + planilha + "] ;", con);
                DataTable produtos = new DataTable();
                da.Fill(produtos);

                MessageBox.Show(produtos.Rows.Count.ToString());

                dtGridProdutos.DataSource = produtos;

                //foreach (DataRow row in dt.Rows)
                //{
                //    cboFor.Items.Add(row["TABLE_NAME"].ToString().Replace("$", "").Replace("'", ""));
                //    i++;
                //}

                con.Close();
                DesignAndActions.ActiveTab(lblTabProd, tmrBorda);
            }
            catch(Exception err)
            {
                Util.ErrorMessage(err.Message);
            }
            
        }

        private void lblTabProd_Click(object sender, EventArgs e)
        {
            DesignAndActions.ActiveTab(sender as Label, tmrBorda);
        }

        private void lblTabClient_Click(object sender, EventArgs e)
        {
            DesignAndActions.ActiveTab(sender as Label, tmrBorda);
        }

        private void lblTabForn_Click(object sender, EventArgs e)
        {
            DesignAndActions.ActiveTab(sender as Label, tmrBorda);
        }

        private void btNeutro_Click(object sender, EventArgs e)
        {
            try
            {
                DefaultModel sql = new FornecedorDAO();
                //DataRowCollection result =  sql.getAll("materiais", "1=1 and mat_001=800 limit 1");

                List<Dictionary<string, dynamic>> bindMaterial = new List<Dictionary<string, dynamic>>();

                //dynamic teste = sql.prepareParams(bindMaterial);
                Dictionary<string, dynamic> nomes = new Dictionary<string, dynamic>
                {
                    {"nome", "Douglas" },
                    {"idade", 35 },
                    {"valor", 12.45 }
                };

                bindMaterial.Add(nomes);

                nomes = new Dictionary<string, dynamic>
                {
                    {"nome", "Rayene" },
                    {"idade", 29 },
                    {"valor", 44.81 }
                };

                bindMaterial.Add(nomes);

                string teste = sql.PrepareUpdate(nomes);

                MessageBox.Show(teste);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Errinho");
            }
        }

        private void btnMin_MouseEnter(object sender, EventArgs e)
        {
            btnMin.BackColor = Color.FromArgb(54, 54, 54);
        }

        private void btnMin_MouseLeave(object sender, EventArgs e)
        {
            btnMin.BackColor = Color.Transparent;
        }

        private void btnSetSystem_Click(object sender, EventArgs e)
        {
            frmConfigImportacao frmConfig = new frmConfigImportacao(this);
            frmConfig.ShowDialog();
        }

        private void pnlDadosImp_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
