using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DDA_And_Bresenham_Algorithm
{
    public partial class Form1 : Form
    {
        string errorMsg = "                  Fill All Fields \nWith Integers Numbers Only!";
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void drawBtn_Click(object sender, EventArgs e)
        {
            ClearDraw();
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_x1.Text,"^-[0-9]+$|^[0-9]+$")  &&
                System.Text.RegularExpressions.Regex.IsMatch(textBox_y1.Text, "^-[0-9]+$|^[0-9]+$") &&
                System.Text.RegularExpressions.Regex.IsMatch(textBox_x2.Text, "^-[0-9]+$|^[0-9]+$") &&
                System.Text.RegularExpressions.Regex.IsMatch(textBox_y2.Text, "^-[0-9]+$|^[0-9]+$"))
            {
                int x1 = Int32.Parse(textBox_x1.Text);
                int y1 = Int32.Parse(textBox_y1.Text);
                int x2 = Int32.Parse(textBox_x2.Text);
                int y2 = Int32.Parse(textBox_y2.Text);

                List<Point> listOfPoints = LineDrawing.lineDDA(x1, y1, x2, y2);
                label_error_msg.Text = "";
                Draw(listOfPoints);
            }
            else
            {
                label_error_msg.Text = errorMsg;
                ClearInputs();
            }
        }

        private void bresBtn_Click(object sender, EventArgs e)
        {
            ClearDraw();
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_x1.Text, "^-[0-9]+$|^[0-9]+$") &&
                System.Text.RegularExpressions.Regex.IsMatch(textBox_y1.Text, "^-[0-9]+$|^[0-9]+$") &&
                System.Text.RegularExpressions.Regex.IsMatch(textBox_x2.Text, "^-[0-9]+$|^[0-9]+$") &&
                System.Text.RegularExpressions.Regex.IsMatch(textBox_y2.Text, "^-[0-9]+$|^[0-9]+$"))
            {
                int x1 = Int32.Parse(textBox_x1.Text);
                int y1 = Int32.Parse(textBox_y1.Text);
                int x2 = Int32.Parse(textBox_x2.Text);
                int y2 = Int32.Parse(textBox_y2.Text);

                List<Point> listOfPoints = LineDrawing.lineBres(x1, y1, x2, y2);
                label_error_msg.Text = "";
                Draw(listOfPoints);
            }
            else
            {
                label_error_msg.Text = errorMsg;
                ClearInputs();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
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
            textBox_x1.Text = "";
            textBox_y1.Text = "";
            textBox_x2.Text = "";
            textBox_y2.Text = "";
        }

        public void ClearInputs()
        {
            textBox_x1.Text = "";
            textBox_y1.Text = "";
            textBox_x2.Text = "";
            textBox_y2.Text = "";
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
