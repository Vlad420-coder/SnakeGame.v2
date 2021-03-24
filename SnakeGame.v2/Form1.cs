using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame.v2
{
    public partial class Form1 : Form
    {
        Snake Snake1 = new Snake {amount = 2, coords = new List<Point>(), XRectSize = 20, YRectSize = 20 };
        string temKey;
       int x=100;
        float y;
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(PressedKey);
        }
        private void PressedKey(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "Up":
                    temKey = "Up";
                    break;
                case "Down":
                    temKey = "Down";
                    break;
                case "Right":
                    temKey = "Right";
                    break;
                case "Left":
                    temKey = "Left";
                    break;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {


            Snake1.coords.Add(new Point { X = 100, Y = 100 });
            Snake1.coords.Add(new Point { X = 79, Y = 100 });
            Snake1.coords.Add(new Point { X = 58, Y = 100 });
            Snake1.coords.Add(new Point { X = 37, Y = 100 });
            Snake1.coords.Add(new Point { X = 16, Y = 100 });



            timer1.Start();
            timer1.Interval = 20;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
                x = Snake1.coords[0].X;
                y = Snake1.coords[0].Y;
                switch (temKey)
                {
                    case "Up":
                        y -= 10;
                        break;
                    case "Down":
                        y += 10;
                        break;
                    case "Right":
                        x += 10;
                        break;
                    case "Left":
                        x -= 10;
                        break;

                }

                Snake1.coords[0] = new Point((int)x, (int)y);
            for (int i =1; i<Snake1.coords.Count; i++)
            {
               x=Snake1.coords[i].X;
                y = Snake1.coords[0].Y;

            }
           


            if (x > pictureBox1.Width)
            {
                x = -20;
            }
            if (x < -20)
            {
                x = pictureBox1.Width;
            }
            if (y > pictureBox1.Height)
            {
                y = -20;
            }
            if (y < -20)
            {
                y = pictureBox1.Height;
            }
            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            for (int i=0; i < Snake1.coords.Count; i++)
            {
                e.Graphics.FillRectangle(Brushes.Green, Snake1.coords[i].X, Snake1.coords[i].Y, Snake1.XRectSize, Snake1.YRectSize);
            }
        }
    }
}
