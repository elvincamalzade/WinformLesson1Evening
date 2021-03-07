using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class Form1 : Form
    {
        Timer Timer = new Timer();
        public Form1()
        {
            InitializeComponent();

            Timer.Tick += Timer_Tick;
            Timer.Interval = 500;
            Timer.Start();

            dateLbl.Text = DateTime.Now.ToLongDateString();


            //Label timeLbl = new Label();
            //timeLbl.Location = new Point(24, 93);
            //timeLbl.BackColor = Color.SpringGreen;
            //timeLbl.Text = $"Time : {DateTime.Now.ToLongTimeString()}";
            //timeLbl.Font = new Font("Comic Sans MS", 36, FontStyle.Bold);
            //timeLbl.AutoSize = true;

            //this.Controls.Add(timeLbl);


            

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            string message = "";
            //if (e.Button == MouseButtons.Left)
            //{
            //    this.BackColor = Color.SpringGreen;
            //}
            //else if (e.Button == MouseButtons.Right)
            //{
            //    this.BackColor = Color.DeepSkyBlue;
            //}
            //message += $"X : {e.X}   Y : {e.Y}";

            MessageBox.Show(message);

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //Task 1
            //Text = $"X : {e.X}   Y : {e.Y}";


            //Task 2

            //if(e.X>0 && e.X <= 200)
            //{
            //    this.BackColor = Color.Yellow;
            //}
            //else if (e.X > 200 && e.X <= 400)
            //{
            //    this.BackColor = Color.Red;
            //}
            //else if (e.X > 400 && e.X <= 600)
            //{
            //    this.BackColor = Color.SpringGreen;
            //}
            //else
            //{
            //    this.BackColor = Color.Gray;
            //}

         



        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            Random random = new Random();
            this.BackColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(sender is Button bt){
                bt.Dispose();

                Button button = new Button();
                button.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
                button.Text = "Click Me";
                button.AutoSize = true;
                button.Click += button1_Click;
                Random random = new Random();
                int randomX = random.Next(this.Size.Width - 100);
                int randomY = random.Next(this.Size.Height - 100);
                button.Location = new Point(randomX, randomY);
                this.Controls.Add(button);

                 
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Mouse Down");
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Mouse Up");
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }
    }
}
