
namespace DDA_And_Bresenham_Algorithm
{
    partial class Form3
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
            this.backBtn = new System.Windows.Forms.Button();
            this.label_error_msg = new System.Windows.Forms.Label();
            this.clearBtn2 = new System.Windows.Forms.Button();
            this.drawEllipseBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_rx = new System.Windows.Forms.TextBox();
            this.textBox_ry = new System.Windows.Forms.TextBox();
            this.textBox_xCenter = new System.Windows.Forms.TextBox();
            this.textBox_yCenter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(719, 412);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 23;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label_error_msg
            // 
            this.label_error_msg.AutoSize = true;
            this.label_error_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error_msg.Location = new System.Drawing.Point(615, 22);
            this.label_error_msg.Name = "label_error_msg";
            this.label_error_msg.Size = new System.Drawing.Size(0, 16);
            this.label_error_msg.TabIndex = 22;
            // 
            // clearBtn2
            // 
            this.clearBtn2.Location = new System.Drawing.Point(719, 376);
            this.clearBtn2.Name = "clearBtn2";
            this.clearBtn2.Size = new System.Drawing.Size(75, 23);
            this.clearBtn2.TabIndex = 21;
            this.clearBtn2.Text = "Clear";
            this.clearBtn2.UseVisualStyleBackColor = true;
            this.clearBtn2.Click += new System.EventHandler(this.clearBtn2_Click);
            // 
            // drawEllipseBtn
            // 
            this.drawEllipseBtn.Location = new System.Drawing.Point(621, 376);
            this.drawEllipseBtn.Name = "drawEllipseBtn";
            this.drawEllipseBtn.Size = new System.Drawing.Size(75, 23);
            this.drawEllipseBtn.TabIndex = 20;
            this.drawEllipseBtn.Text = "Draw Ellipse";
            this.drawEllipseBtn.UseVisualStyleBackColor = true;
            this.drawEllipseBtn.Click += new System.EventHandler(this.drawEllipseBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(631, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "ry";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(631, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "rx";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Location = new System.Drawing.Point(6, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 458);
            this.panel1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(633, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(633, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "X";
            // 
            // textBox_rx
            // 
            this.textBox_rx.Location = new System.Drawing.Point(669, 97);
            this.textBox_rx.Name = "textBox_rx";
            this.textBox_rx.Size = new System.Drawing.Size(100, 20);
            this.textBox_rx.TabIndex = 26;
            // 
            // textBox_ry
            // 
            this.textBox_ry.Location = new System.Drawing.Point(669, 129);
            this.textBox_ry.Name = "textBox_ry";
            this.textBox_ry.Size = new System.Drawing.Size(100, 20);
            this.textBox_ry.TabIndex = 27;
            // 
            // textBox_xCenter
            // 
            this.textBox_xCenter.Location = new System.Drawing.Point(669, 172);
            this.textBox_xCenter.Name = "textBox_xCenter";
            this.textBox_xCenter.Size = new System.Drawing.Size(100, 20);
            this.textBox_xCenter.TabIndex = 28;
            // 
            // textBox_yCenter
            // 
            this.textBox_yCenter.Location = new System.Drawing.Point(669, 204);
            this.textBox_yCenter.Name = "textBox_yCenter";
            this.textBox_yCenter.Size = new System.Drawing.Size(100, 20);
            this.textBox_yCenter.TabIndex = 29;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_yCenter);
            this.Controls.Add(this.textBox_xCenter);
            this.Controls.Add(this.textBox_ry);
            this.Controls.Add(this.textBox_rx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.label_error_msg);
            this.Controls.Add(this.clearBtn2);
            this.Controls.Add(this.drawEllipseBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Ellipse Drawing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label_error_msg;
        private System.Windows.Forms.Button clearBtn2;
        private System.Windows.Forms.Button drawEllipseBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_rx;
        private System.Windows.Forms.TextBox textBox_ry;
        private System.Windows.Forms.TextBox textBox_xCenter;
        private System.Windows.Forms.TextBox textBox_yCenter;
    }
}