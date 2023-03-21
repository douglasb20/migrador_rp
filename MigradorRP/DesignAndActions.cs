using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Linq.Expressions;

namespace MigradorRP
{
    public static class DesignAndActions
    {
        private static Label lblActivated;
        public static void lblMouseEnter(object sender, EventArgs e)
        {
            Label lblTarget = (Label)sender;
            if(lblTarget != lblActivated)
            {
                lblTarget.BackColor = Color.FromArgb(54, 54, 54);
            }
        }

        public static void lblMouseOut(object sender, EventArgs e)
        {
            Label lblTarget = (Label)sender;
            if(lblTarget != lblActivated)
            {
                lblTarget.BackColor = Color.Transparent;
            }
        }

        public static void ActiveTab(Label sender, Timer tmr)
        {
            DesactiveTabs();
            Label lblTarget = sender;
            lblActivated = sender;
            tmr.Enabled = true;

            lblTarget.BackColor = Color.FromArgb(255, 192, 128);
            lblTarget.ForeColor = Color.Black;

        }

        public static void timer1_Tick(object sender, EventArgs e)
        {
            Panel pnlBorda = Application.OpenForms["frmMain"].Controls["panel1"].Controls["pnlBorda"] as Panel;
            int toPosition = lblActivated.Left - pnlBorda.Left;
            bool type = toPosition > 0 ? true : false;
            Timer tmr = (Timer)sender;

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
                tmr.Stop();
            }
        }

        public static void DesactiveTabs()
        {

            Label l1 = (Label)Application.OpenForms["frmMain"].Controls["panel1"].Controls["lblTabProd"];
            Label l2 = (Label)Application.OpenForms["frmMain"].Controls["panel1"].Controls["lblTabClient"];
            Label l3 = (Label)Application.OpenForms["frmMain"].Controls["panel1"].Controls["lblTabForn"];

            l1.BackColor = Color.Transparent;
            l1.ForeColor = Color.White;

            l2.BackColor = Color.Transparent;
            l2.ForeColor= Color.White;

            l3.BackColor = Color.Transparent;
            l3.ForeColor= Color.White;

        }
    }
}
