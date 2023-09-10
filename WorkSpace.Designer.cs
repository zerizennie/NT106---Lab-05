namespace basic_whiteboard
{
    partial class WorkSpace
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
            textBox1 = new System.Windows.Forms.TextBox();
            canvas = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            BlackBox = new System.Windows.Forms.PictureBox();
            WhiteBox = new System.Windows.Forms.PictureBox();
            BlueBox = new System.Windows.Forms.PictureBox();
            OrangeBox = new System.Windows.Forms.PictureBox();
            CyanBox = new System.Windows.Forms.PictureBox();
            GreenBox = new System.Windows.Forms.PictureBox();
            RedBox = new System.Windows.Forms.PictureBox();
            YellowBox = new System.Windows.Forms.PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BlackBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WhiteBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BlueBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrangeBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CyanBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GreenBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RedBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)YellowBox).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(26, 11);
            textBox1.Margin = new System.Windows.Forms.Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(121, 27);
            textBox1.TabIndex = 0;
            // 
            // canvas
            // 
            canvas.BackColor = System.Drawing.Color.White;
            canvas.Location = new System.Drawing.Point(173, 51);
            canvas.Name = "canvas";
            canvas.Size = new System.Drawing.Size(577, 395);
            canvas.TabIndex = 1;
            //canvas.MouseDown += cstpnlWhiteboard_MouseDown_1;
            //canvas.MouseMove += cstpnlWhiteboard_MouseMove_1;
            //canvas.MouseUp += cstpnlWhiteboard_MouseUp_1;

            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.SeaShell;
            panel1.Controls.Add(BlackBox);
            panel1.Controls.Add(WhiteBox);
            panel1.Controls.Add(BlueBox);
            panel1.Controls.Add(OrangeBox);
            panel1.Controls.Add(CyanBox);
            panel1.Controls.Add(GreenBox);
            panel1.Controls.Add(RedBox);
            panel1.Controls.Add(YellowBox);
            panel1.Location = new System.Drawing.Point(26, 51);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(121, 188);
            panel1.TabIndex = 0;
            // 
            // BlackBox
            // 
            BlackBox.BackColor = System.Drawing.Color.Black;
            BlackBox.Location = new System.Drawing.Point(67, 140);
            BlackBox.Name = "BlackBox";
            BlackBox.Size = new System.Drawing.Size(37, 36);
            BlackBox.TabIndex = 7;
            BlackBox.TabStop = false;
            BlackBox.Click += BlackBox_Click;
            // 
            // WhiteBox
            // 
            WhiteBox.BackColor = System.Drawing.Color.White;
            WhiteBox.Location = new System.Drawing.Point(14, 140);
            WhiteBox.Name = "WhiteBox";
            WhiteBox.Size = new System.Drawing.Size(37, 36);
            WhiteBox.TabIndex = 6;
            WhiteBox.TabStop = false;
            WhiteBox.Click += BlackBox_Click;
            // 
            // BlueBox
            // 
            BlueBox.BackColor = System.Drawing.Color.Blue;
            BlueBox.Location = new System.Drawing.Point(67, 98);
            BlueBox.Name = "BlueBox";
            BlueBox.Size = new System.Drawing.Size(37, 36);
            BlueBox.TabIndex = 5;
            BlueBox.TabStop = false;
            BlueBox.Click += BlackBox_Click;
            // 
            // OrangeBox
            // 
            OrangeBox.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            OrangeBox.Location = new System.Drawing.Point(14, 98);
            OrangeBox.Name = "OrangeBox";
            OrangeBox.Size = new System.Drawing.Size(37, 36);
            OrangeBox.TabIndex = 4;
            OrangeBox.TabStop = false;
            OrangeBox.Click += BlackBox_Click;
            // 
            // CyanBox
            // 
            CyanBox.BackColor = System.Drawing.Color.Cyan;
            CyanBox.Location = new System.Drawing.Point(67, 56);
            CyanBox.Name = "CyanBox";
            CyanBox.Size = new System.Drawing.Size(37, 36);
            CyanBox.TabIndex = 3;
            CyanBox.TabStop = false;
            CyanBox.Click += BlackBox_Click;
            // 
            // GreenBox
            // 
            GreenBox.BackColor = System.Drawing.Color.Lime;
            GreenBox.Location = new System.Drawing.Point(14, 56);
            GreenBox.Name = "GreenBox";
            GreenBox.Size = new System.Drawing.Size(37, 36);
            GreenBox.TabIndex = 2;
            GreenBox.TabStop = false;
            // 
            // RedBox
            // 
            RedBox.BackColor = System.Drawing.Color.Red;
            RedBox.Location = new System.Drawing.Point(67, 14);
            RedBox.Name = "RedBox";
            RedBox.Size = new System.Drawing.Size(37, 36);
            RedBox.TabIndex = 1;
            RedBox.TabStop = false;
            RedBox.Click += BlackBox_Click;
            // 
            // YellowBox
            // 
            YellowBox.BackColor = System.Drawing.Color.Yellow;
            YellowBox.Location = new System.Drawing.Point(14, 14);
            YellowBox.Name = "YellowBox";
            YellowBox.Size = new System.Drawing.Size(37, 36);
            YellowBox.TabIndex = 0;
            YellowBox.TabStop = false;
            YellowBox.Click += BlackBox_Click;
            // 
            // WorkSpace
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(764, 458);
            Controls.Add(panel1);
            Controls.Add(canvas);
            Controls.Add(textBox1);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "WorkSpace";
            Text = "WorkSpace";
            Load += WorkSpace_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BlackBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)WhiteBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BlueBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrangeBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)CyanBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)GreenBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)RedBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)YellowBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox BlackBox;
        private System.Windows.Forms.PictureBox WhiteBox;
        private System.Windows.Forms.PictureBox BlueBox;
        private System.Windows.Forms.PictureBox OrangeBox;
        private System.Windows.Forms.PictureBox CyanBox;
        private System.Windows.Forms.PictureBox GreenBox;
        private System.Windows.Forms.PictureBox RedBox;
        private System.Windows.Forms.PictureBox YellowBox;
    }
}