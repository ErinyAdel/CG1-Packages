using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDA_And_Bresenham_Algorithm
{
    public partial class Form3 : Form
    {
        string errorMsg = "                  Fill All Fields \n With Integers Numbers Only!";
        public Form3()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void drawEllipseBtn_Click(object sender, EventArgs e)
        {
            ClearDraw();
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_rx.Text, "^-[0-9]+$|^[0-9]+$") &&
                System.Text.RegularExpressions.Regex.IsMatch(textBox_ry.Text, "^-[0-9]+$|^[0-9]+$") &&
                System.Text.RegularExpressions.Regex.IsMatch(textBox_xCenter.Text, "^-[0-9]+$|^[0-9]+$") &&
                System.Text.RegularExpressions.Regex.IsMatch(textBox_yCenter.Text, "^-[0-9]+$|^[0-9]+$") )
            {
                int rx = Int32.Parse(textBox_rx.Text);
                int ry = Int32.Parse(textBox_ry.Text);
                int xC = Int32.Parse(textBox_xCenter.Text);
                int yC = Int32.Parse(textBox_yCenter.Text);

                List<Point> listOfPoints = EllipseDrawing.ellipseMidpoint(xC,yC,rx,ry);
                label_error_msg.Text = "";
                Draw(listOfPoints);
            }
            else
            {
                label_error_msg.Text = errorMsg;
                ClearInputs();
            }
        }

        private void clearBtn2_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Home ch = new Home();
            this.Hide();
            ch.Show();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////
        public void Draw(List<Point> p)
        {
            for (int i = 0; i < p.Count; i++)
                panel1.CreateGraphics().FillRectangle(Brushes.Black, p[i].X, p[i].Y, 1, 1);
        }

        public void ClearAll()
        {
            ClearDraw();
            label_error_msg.Text = "";
            textBox_rx.Text = "";
            textBox_ry.Text = "";
            textBox_xCenter.Text = "";
            textBox_yCenter.Text = "";
        }

        public void ClearInputs()
        {
            textBox_rx.Text = "";
            textBox_ry.Text = "";
            textBox_xCenter.Text = "";
            textBox_yCenter.Text = "";
        }

        public void ClearDraw()
        {
            panel1.CreateGraphics().Clear(Color.LightSteelBlue);
        }
    }
}
