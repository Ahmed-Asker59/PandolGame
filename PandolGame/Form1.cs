namespace PandolGame
{
    public partial class Form1 : Form
    {
        private int angle = 0;
        private bool swingingRight = true;
        private Point ballPosition;
        private Point pivotPoint;
        private bool isRunning = false;
        public Form1()
        {
            InitializeComponent();
            //point to start draw rope
            pivotPoint = new Point(this.ClientSize.Width / 2, 50);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateBallPosition();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Swing logic
            if (swingingRight)
            {
                angle += 2;
                if (angle >= 90)
                {
                    swingingRight = false;
                }
            }
            else
            {
                angle -= 2;
                if (angle <= -90)
                {
                    swingingRight = true;
                }
            }
            UpdateBallPosition();
            Invalidate();
        }

        private void UpdateBallPosition()
        {

            // Update ball position
            int radius = 300; // Length of the rope
            double radian = angle * (Math.PI / 180);
            int ballX = pivotPoint.X + (int)(radius * Math.Sin(radian));
            int ballY = pivotPoint.Y + (int)(radius * Math.Cos(radian));


            picBall.Location = new Point(ballX - (picBall.Width / 2), ballY - (picBall.Height / 2));

            ballPosition = picBall.Location;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen ropePen = new Pen(Color.Black, 2);

            // Draw the rope
            g.DrawLine(ropePen, pivotPoint, new Point(ballPosition.X + (picBall.Width / 2), ballPosition.Y + (picBall.Height / 2)));
        }



        private void ToggleButtonClicked(object sender, EventArgs e)
        {
            if (isRunning)
            {
                timer1.Stop();
                ToggleButton.Text = "Start";
            }
            else
            {
                timer1.Start();
                ToggleButton.Text = "Stop";
            }
            isRunning = !isRunning;
        }
    }
}