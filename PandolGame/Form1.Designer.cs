namespace PandolGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            picBall = new PictureBox();
            ToggleButton = new Button();
            ((System.ComponentModel.ISupportInitialize)picBall).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 25;
            timer1.Tick += timer1_Tick;
            // 
            // picBall
            // 
            picBall.Image = Properties.Resources.swinging_ball;
            picBall.Location = new Point(289, 166);
            picBall.Name = "picBall";
            picBall.Size = new Size(148, 90);
            picBall.SizeMode = PictureBoxSizeMode.StretchImage;
            picBall.TabIndex = 0;
            picBall.TabStop = false;
            // 
            // ToggleButton
            // 
            ToggleButton.Location = new Point(306, 397);
            ToggleButton.Name = "ToggleButton";
            ToggleButton.Size = new Size(192, 29);
            ToggleButton.TabIndex = 1;
            ToggleButton.Text = "Start";
            ToggleButton.UseVisualStyleBackColor = true;
            ToggleButton.Click += ToggleButtonClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ToggleButton);
            Controls.Add(picBall);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Paint += Form1_Paint;
            ((System.ComponentModel.ISupportInitialize)picBall).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private PictureBox picBall;
        private Button ToggleButton;
    }
}