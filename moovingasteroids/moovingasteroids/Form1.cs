using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moovingasteroids
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        List<Asteroid> asts;
        Brush b = new SolidBrush(Color.Green);

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            

            asts = new List<Asteroid>();
           
            asts.Add(new Asteroid(new Point(200, 200), -5, 4));
            asts.Add(new Asteroid(new Point(400, 200), -9, 4));
            asts.Add(new Asteroid(new Point(300, 100), -2, 6));
            asts.Add(new Asteroid(new Point(230, 130), -2, 2));
            asts.Add(new Asteroid(new Point(330, 90), -2, 2));

            

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.Black);
            foreach (Asteroid a in asts)
            {
                a.move();
                a.draw(g);
                g.FillRectangle(b, 250, 250, 10, 10); // starship
            }
        }
    }
}
