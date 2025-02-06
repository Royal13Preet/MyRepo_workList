namespace CarRace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemys(gamespeed);
            gameover();
        }

        Random r = new Random();
        int x, y;
        void enemys(int speed)
        {
            if (enemy.Top >= 500)
            {
                x = r.Next(0, 200);

                enemy.Location = new Point(x, 0);
            }
            else
            {
                enemy.Top += speed;
            }
            if (enemy1.Top >= 500)
            {
                x = r.Next(0, 400);

                enemy1.Location = new Point(x, 0);
            }
            else

            {
                enemy1.Top += speed;
            }
            if (enemy2.Top >= 500)
            {
                x = r.Next(200, 350);

                enemy2.Location = new Point(x, 0);
            }
            else
            {
                enemy2.Top += speed;
            }
        }

        void gameover()
        {
            if (car.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
            }
            if (car.Bounds.IntersectsWith(enemy.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
            }
            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
            }
        }
        void moveline(int speed)
        {
            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;

            }
            else
            {
                pictureBox1.Top += speed;
            }
            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }

            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }
            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }


        }
        int gamespeed = 0;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (car.Left > 10)
                    car.Left += -8;
            }

            if (e.KeyCode == Keys.Right)
            {

                if (car.Right < 370)
                {
                    car.Left += 8;
                }


            }

            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                {
                    gamespeed++;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                {
                    gamespeed--;
                }
            }
        }

        private void enemy_Click(object sender, EventArgs e)
        {

        }
    }
}
