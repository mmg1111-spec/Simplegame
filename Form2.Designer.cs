namespace gametestttt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.point1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.point2 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.point3 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.freddy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.point1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.point2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.point3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freddy)).BeginInit();
            this.SuspendLayout();
            // 
            // point1
            // 
            this.point1.Image = ((System.Drawing.Image)(resources.GetObject("point1.Image")));
            this.point1.Location = new System.Drawing.Point(-2, 0);
            this.point1.Name = "point1";
            this.point1.Size = new System.Drawing.Size(1416, 882);
            this.point1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.point1.TabIndex = 0;
            this.point1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(541, 655);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "앞으로";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(67, 705);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "왼쪽으로";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(1038, 690);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 56);
            this.button3.TabIndex = 3;
            this.button3.Text = "오른쪽으로";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // point2
            // 
            this.point2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.point2.Image = ((System.Drawing.Image)(resources.GetObject("point2.Image")));
            this.point2.Location = new System.Drawing.Point(-2, 0);
            this.point2.Name = "point2";
            this.point2.Size = new System.Drawing.Size(1416, 873);
            this.point2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.point2.TabIndex = 4;
            this.point2.TabStop = false;
            this.point2.Visible = false;
            this.point2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(567, 649);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 68);
            this.button4.TabIndex = 5;
            this.button4.Text = "더 앞으로 나아간다";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(122, 690);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(234, 56);
            this.button5.TabIndex = 6;
            this.button5.Text = "이번엔 왼쪽으로";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(1010, 661);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(246, 56);
            this.button6.TabIndex = 7;
            this.button6.Text = "이번엔 오른쪽으로";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // point3
            // 
            this.point3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.point3.Image = ((System.Drawing.Image)(resources.GetObject("point3.Image")));
            this.point3.Location = new System.Drawing.Point(122, 582);
            this.point3.Name = "point3";
            this.point3.Size = new System.Drawing.Size(22, 48);
            this.point3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.point3.TabIndex = 8;
            this.point3.TabStop = false;
            this.point3.Visible = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Location = new System.Drawing.Point(122, 683);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(243, 70);
            this.button7.TabIndex = 9;
            this.button7.Text = "왼쪽으로 이동하자.";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // freddy
            // 
            this.freddy.Image = ((System.Drawing.Image)(resources.GetObject("freddy.Image")));
            this.freddy.Location = new System.Drawing.Point(-2, 0);
            this.freddy.Name = "freddy";
            this.freddy.Size = new System.Drawing.Size(1416, 882);
            this.freddy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.freddy.TabIndex = 12;
            this.freddy.TabStop = false;
            this.freddy.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 873);
            this.Controls.Add(this.freddy);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.point3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.point2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.point1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.point1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.point2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.point3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freddy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox point1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox point2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox point3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox freddy;
    }
}