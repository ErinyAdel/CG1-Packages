using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DDA_And_Bresenham_Algorithm
{
    public partial class Form2 : Form
    {
        string errorMsg = "                  Fill All Fields \n With Integers Numbers Only!";
        public Form2()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void drawCircleBtn_Click(object sender, EventArgs e)
        {
            ClearDraw();
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_x.Text, "^-[0-9]+$|^[0-9]+$") &&
                System.Text.RegularExpressions.Regex.IsMatch(textBox_y.Text, "^-[0-9]+$|^[0-9]+$") &&
                System.Text.RegularExpressions.Regex.IsMatch(textBox_r.Text, "^-[0-9]+$|^[0-9]+$") )
            {
                int x = Int32.Parse(textBox_x.Text);
                int y = Int32.Parse(textBox_y.Text);
                int r = Int32.Parse(textBox_r.Text);

                List<Point> listOfPoints = CircleDrawing.circleMidpoint(x,y,r);
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
            textBox_x.Text = "";
            textBox_y.Text = "";
            textBox_r.Text = "";
        }

        public void ClearInputs()
        {
            textBox_x.Text = "";
            textBox_y.Text = "";
            textBox_r.Text = "";
        }

        public void ClearDraw()
        {
            panel1.CreateGraphics().Clear(Color.LightSteelBlue);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Home ch = new Home();
            this.Hide();
            ch.Show();
        }
    }
}
