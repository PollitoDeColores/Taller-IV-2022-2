using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace VisualCoachPrototype
{
    public partial class Form1 : Form
    {
        Color warningColor = new Color();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*BrakeBtn.Visible = false;
            LeftBtn.Visible = false;
            NormalLeftBtn.Visible = false;
            NormalRightBtn.Visible = false;
            RightBtn.Visible = false;
            SharpLeftBtn.Visible = false;
            SharpRightBtn.Visible = false;
            WOTBtn.Visible = false;
            warningColor = Color.Empty;*/
        }
        public void warningSender(Color color, int side)
        {
            switch (side)
            {
                case 1:
                    LeftWarning.Visible = true;
                    BrakeWarning.Visible = false;
                    WOTWarning.Visible = false;
                    RightWarning.Visible = false;
                    LeftWarning.BackColor = color;
                    LeftBtn.BackColor = color;
                    SharpLeftBtn.BackColor = color;
                    NormalLeftBtn.BackColor = color;
                    BrakeBtn.BackColor = color;
                    break;

                case 2:
                    LeftWarning.Visible = false;
                    BrakeWarning.Visible = false;
                    WOTWarning.Visible = false;
                    RightWarning.Visible = true;
                    RightWarning.BackColor = color;
                    RightBtn.BackColor = color;
                    SharpRightBtn.BackColor = color;
                    NormalRightBtn.BackColor = color;
                    WOTBtn.BackColor = color;
                    break;

                case 3:
                    LeftWarning.Visible = false;
                    BrakeWarning.Visible = false;
                    WOTWarning.Visible = true;
                    RightWarning.Visible = false;
                    WOTWarning.BackColor = color;
                    WOTBtn.BackColor = color;
                    SharpRightBtn.BackColor = color;
                    SharpLeftBtn.BackColor = color;
                    break;

                case 4:
                    LeftWarning.Visible = false;
                    BrakeWarning.Visible = true;
                    WOTWarning.Visible = false;
                    RightWarning.Visible = false;
                    BrakeWarning.BackColor = color;
                    BrakeBtn.BackColor = color;
                    RightBtn.BackColor = color;
                    LeftBtn.BackColor = color;
                    break;

            }
        }

        private void SharpLeftBtn_Click(object sender, EventArgs e)
        {
            warningColor = Color.Red;
            warningSender(warningColor, 1);
        }

        private void SharpRightBtn_Click(object sender, EventArgs e)
        {
            warningColor = Color.Red;
            warningSender(warningColor, 2);
        }

        private void NormalLeftBtn_Click(object sender, EventArgs e)
        {
            warningColor = Color.YellowGreen;
            warningSender(warningColor, 1);
        }

        private void NormalRightBtn_Click(object sender, EventArgs e)
        {
            warningColor = Color.YellowGreen;
            warningSender(warningColor, 2);
        }

        private void LeftBtn_Click(object sender, EventArgs e)
        {
            warningColor = Color.SkyBlue;
            warningSender(warningColor, 1);
        }

        private void RightBtn_Click(object sender, EventArgs e)
        {
            warningColor = Color.SkyBlue;
            warningSender(warningColor, 2);
        }

        private void WOTBtn_Click(object sender, EventArgs e)
        {
            warningColor = Color.DarkCyan;
            warningSender(warningColor, 3);
        }

        private void BrakeBtn_Click(object sender, EventArgs e)
        {
            warningColor = Color.Crimson;
            warningSender(warningColor, 4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            warningColor = Color.White;
            LeftWarning.BackColor = warningColor;
            LeftBtn.BackColor = warningColor;
            SharpLeftBtn.BackColor = warningColor;
            NormalLeftBtn.BackColor = warningColor;
            RightWarning.BackColor = warningColor;
            RightBtn.BackColor = warningColor;
            SharpRightBtn.BackColor = warningColor;
            NormalRightBtn.BackColor = warningColor;
            WOTBtn.BackColor = warningColor;
            BrakeBtn.BackColor = warningColor;
            BrakeWarning.BackColor = warningColor;
            WOTWarning.BackColor = warningColor;
        }

    }
}
