using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Reflection;
using System.IO;

namespace MigradorRP
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(frmMain1_Paint);
        }

        public static string caminho                    = Path.GetDirectoryName(Application.ExecutablePath);
        public static string fileConfig                 = "config.conf";
        public static string pathConfig                 = Path.Combine( caminho , fileConfig);
        public static Dictionary<string, string> config;
        public string titulo = ConfigurationManager.AppSettings["appTitle"];

        private void frmMain1_Paint(object sender, PaintEventArgs e)
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
            try
            {
                ConfigReader.SetFilePath(pathConfig);
                config = ConfigReader.config();

                lblTopBar.Text = titulo.ToString() + " | MigradorRP" ;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
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
    }
}
