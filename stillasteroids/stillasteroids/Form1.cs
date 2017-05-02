using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stillasteroids
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;
        Pen pen = new Pen(Color.White);
        Brush b = new SolidBrush(Color.Green);
       
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = this.CreateGraphics();
            
            
            //asteroids
            g.DrawEllipse(pen, 100, 100, 30, 30);
            g.DrawEllipse(pen, 200, 200, 30, 30);
            g.DrawEllipse(pen, 400, 300, 30, 30);
            g.DrawEllipse(pen, 100, 400, 30, 30);

            //starship (or smth)
            g.FillRectangle(b, 250, 250, 10, 10);
        }
    }
}
