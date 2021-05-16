
namespace DDA_And_Bresenham_Algorithm
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_x1 = new System.Windows.Forms.TextBox();
            this.textBox_y1 = new System.Windows.Forms.TextBox();
            this.textBox_x2 = new System.Windows.Forms.TextBox();
            this.textBox_y2 = new System.Windows.Forms.TextBox();
            this.drawBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.label_error_msg = new System.Windows.Forms.Label();
            this.bresBtn = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(625, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(625, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "X2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(625, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Y2";
            // 
            // textBox_x1
            // 
            this.textBox_x1.Location = new System.Drawing.Point(666, 97);
            this.textBox_x1.Name = "textBox_x1";
            this.textBox_x1.Size = new System.Drawing.Size(100, 20);
            this.textBox_x1.TabIndex = 5;
            // 
            // textBox_y1
            // 
            this.textBox_y1.Location = new System.Drawing.Point(666, 132);
            this.textBox_y1.Name = "textBox_y1";
            this.textBox_y1.Size = new System.Drawing.Size(100, 20);
            this.textBox_y1.TabIndex = 6;
            // 
            // textBox_x2
            // 
            this.textBox_x2.Location = new System.Drawing.Point(667, 172);
            this.textBox_x2.Name = "textBox_x2";
            this.textBox_x2.Size = new System.Drawing.Size(100, 20);
            this.textBox_x2.TabIndex = 7;
            // 
            // textBox_y2
            // 
            this.textBox_y2.Location = new System.Drawing.Point(667, 207);
            this.textBox_y2.Name = "textBox_y2";
            this.textBox_y2.Size = new System.Drawing.Size(100, 20);
            this.textBox_y2.TabIndex = 8;
            // 
            // drawBtn
            // 
            this.drawBtn.Location = new System.Drawing.Point(615, 380);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(75, 23);
            this.drawBtn.TabIndex = 9;
            this.drawBtn.Text = "DDA Draw";
            this.drawBtn.UseVisualStyleBackColor = true;
            this.drawBtn.Click += new System.EventHandler(this.drawBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(615, 415);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 10;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
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
            // bresBtn
            // 
            this.bresBtn.Location = new System.Drawing.Point(713, 380);
            this.bresBtn.Name = "bresBtn";
            this.bresBtn.Size = new System.Drawing.Size(75, 23);
            this.bresBtn.TabIndex = 12;
            this.bresBtn.Text = "Bres Draw";
            this.bresBtn.UseVisualStyleBackColor = true;
            this.bresBtn.Click += new System.EventHandler(this.bresBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(713, 415);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 13;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.bresBtn);
            this.Controls.Add(this.label_error_msg);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.drawBtn);
            this.Controls.Add(this.textBox_y2);
            this.Controls.Add(this.textBox_x2);
            this.Controls.Add(this.textBox_y1);
            this.Controls.Add(this.textBox_x1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "DDA & Bresenham  Algorithms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button drawBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button bresBtn;
        public System.Windows.Forms.TextBox textBox_x1;
        public System.Windows.Forms.TextBox textBox_y1;
        public System.Windows.Forms.TextBox textBox_x2;
        public System.Windows.Forms.TextBox textBox_y2;
        public System.Windows.Forms.Label label_error_msg;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backBtn;
    }
}

