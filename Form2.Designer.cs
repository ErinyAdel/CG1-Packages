
namespace DDA_And_Bresenham_Algorithm
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_x = new System.Windows.Forms.TextBox();
            this.textBox_y = new System.Windows.Forms.TextBox();
            this.textBox_r = new System.Windows.Forms.TextBox();
            this.drawCircleBtn = new System.Windows.Forms.Button();
            this.clearBtn2 = new System.Windows.Forms.Button();
            this.label_error_msg = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 458);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(625, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(625, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(625, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Radius";
            // 
            // textBox_x
            // 
            this.textBox_x.Location = new System.Drawing.Point(666, 97);
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.Size = new System.Drawing.Size(100, 20);
            this.textBox_x.TabIndex = 5;
            // 
            // textBox_y
            // 
            this.textBox_y.Location = new System.Drawing.Point(666, 132);
            this.textBox_y.Name = "textBox_y";
            this.textBox_y.Size = new System.Drawing.Size(100, 20);
            this.textBox_y.TabIndex = 6;
            // 
            // textBox_r
            // 
            this.textBox_r.Location = new System.Drawing.Point(667, 172);
            this.textBox_r.Name = "textBox_r";
            this.textBox_r.Size = new System.Drawing.Size(100, 20);
            this.textBox_r.TabIndex = 7;
            // 
            // drawCircleBtn
            // 
            this.drawCircleBtn.Location = new System.Drawing.Point(615, 380);
            this.drawCircleBtn.Name = "drawCircleBtn";
            this.drawCircleBtn.Size = new System.Drawing.Size(75, 23);
            this.drawCircleBtn.TabIndex = 9;
            this.drawCircleBtn.Text = "Draw Circle";
            this.drawCircleBtn.UseVisualStyleBackColor = true;
            this.drawCircleBtn.Click += new System.EventHandler(this.drawCircleBtn_Click);
            // 
            // clearBtn2
            // 
            this.clearBtn2.Location = new System.Drawing.Point(713, 380);
            this.clearBtn2.Name = "clearBtn2";
            this.clearBtn2.Size = new System.Drawing.Size(75, 23);
            this.clearBtn2.TabIndex = 10;
            this.clearBtn2.Text = "Clear";
            this.clearBtn2.UseVisualStyleBackColor = true;
            this.clearBtn2.Click += new System.EventHandler(this.clearBtn2_Click);
            // 
            // label_error_msg
            // 
            this.label_error_msg.AutoSize = true;
            this.label_error_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error_msg.Location = new System.Drawing.Point(609, 26);
            this.label_error_msg.Name = "label_error_msg";
            this.label_error_msg.Size = new System.Drawing.Size(0, 16);
            this.label_error_msg.TabIndex = 11;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(713, 416);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 12;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.label_error_msg);
            this.Controls.Add(this.clearBtn2);
            this.Controls.Add(this.drawCircleBtn);
            this.Controls.Add(this.textBox_r);
            this.Controls.Add(this.textBox_y);
            this.Controls.Add(this.textBox_x);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Circle Drawing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button drawCircleBtn;
        private System.Windows.Forms.Button clearBtn2;
        public System.Windows.Forms.TextBox textBox_x;
        public System.Windows.Forms.TextBox textBox_y;
        public System.Windows.Forms.TextBox textBox_r;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_error_msg;
        private System.Windows.Forms.Button backBtn;
    }
}

