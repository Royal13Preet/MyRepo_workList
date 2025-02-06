namespace CarRace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            car = new PictureBox();
            enemy = new PictureBox();
            enemy2 = new PictureBox();
            enemy1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)car).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonFace;
            pictureBox1.Location = new Point(173, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(10, 106);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonFace;
            pictureBox2.Location = new Point(173, 119);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(10, 106);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ButtonFace;
            pictureBox3.Location = new Point(173, 242);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(10, 106);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ButtonFace;
            pictureBox4.Location = new Point(173, 365);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(10, 106);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.ButtonFace;
            pictureBox5.Location = new Point(-4, -4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(10, 475);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = SystemColors.ButtonFace;
            pictureBox6.Location = new Point(376, -4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(10, 475);
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // car
            // 
            car.Image = (Image)resources.GetObject("car.Image");
            car.Location = new Point(65, 330);
            car.Name = "car";
            car.Size = new Size(66, 79);
            car.SizeMode = PictureBoxSizeMode.StretchImage;
            car.TabIndex = 6;
            car.TabStop = false;
            // 
            // enemy
            // 
            enemy.Image = (Image)resources.GetObject("enemy.Image");
            enemy.Location = new Point(24, 21);
            enemy.Name = "enemy";
            enemy.Size = new Size(55, 54);
            enemy.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy.TabIndex = 7;
            enemy.TabStop = false;
            enemy.Click += enemy_Click;
            // 
            // enemy2
            // 
            enemy2.Image = (Image)resources.GetObject("enemy2.Image");
            enemy2.Location = new Point(218, 158);
            enemy2.Name = "enemy2";
            enemy2.Size = new Size(55, 54);
            enemy2.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy2.TabIndex = 8;
            enemy2.TabStop = false;
            // 
            // enemy1
            // 
            enemy1.Image = (Image)resources.GetObject("enemy1.Image");
            enemy1.Location = new Point(286, 48);
            enemy1.Name = "enemy1";
            enemy1.Size = new Size(55, 54);
            enemy1.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy1.TabIndex = 9;
            enemy1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(123, 91);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 10;
            label1.Text = "Game Over";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(384, 461);
            Controls.Add(label1);
            Controls.Add(enemy1);
            Controls.Add(enemy2);
            Controls.Add(enemy);
            Controls.Add(car);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)car).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer1;
        private PictureBox car;
        private PictureBox enemy;
        private PictureBox enemy2;
        private PictureBox enemy1;
        private Label label1;
    }
}
