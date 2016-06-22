using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawGraph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            String string1;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            int X0 = 50, Y0 = 20;
            int SIZE = 40;
            //draw graph domain
            g.FillRectangle(Brushes.LightGray, X0, Y0, SIZE * 10, SIZE * 10);
            //draw axis
            Pen pen1 = new Pen(Color.Black, 2);//where 2 is pixel point
            g.DrawLine(pen1, X0, Y0 + 5 * SIZE, X0 + 10 * SIZE, Y0 + 5 * SIZE);//row
            g.DrawLine(pen1, X0 + 5 * SIZE, Y0, X0 + 5 * SIZE, Y0 + 10 * SIZE);//column
            //draw grid
            for (int i = 0; i <= 10; i++)
            {
                g.DrawLine(Pens.Black, X0, Y0 + i * SIZE, X0 + 10 * SIZE, Y0 + i * SIZE);
                g.DrawLine(Pens.Black, X0 + i * SIZE, Y0, X0 + i * SIZE, Y0 + 10 * SIZE);
            }
            //digit
            for (int i = -5; i <= 5; ++i)
            {
                string1 = String.Format("{0,3:D}", i);
                g.DrawString(string1, Font, Brushes.Black, X0 - 17 + ((i + 5) * SIZE), Y0 + 10 * SIZE + 13);
                g.DrawString(string1, Font, Brushes.Black, X0 - 30, Y0 - 5 + ((5 - i) * SIZE));
            }

            //draw graph or plot
            for (float x = -5; x < 5; x += 0.02F)
            {
                float y = x*x + 2 * x - 2;
                float xx = X0 + ( x + 5) * SIZE;
                float yy = Y0 + (-y + 5) * SIZE;
                if (-5 < y && y < 5)
                {
                    //plot
                    //FillRectangle(colo,xloc,yloc,widht,height)
                    g.FillRectangle(Brushes.Red, xx, yy, 1, 1);
                }
            }

            float old_xx = 0F, old_yy = 0F;
            for (float x = -5; x < 5; x += 0.02F)
            {
                float y = x * x - 2 * x - 2;
                float xx = X0 + (x + 5) * SIZE;
                float yy = Y0 + (-y + 5) * SIZE;
                if (x!=-5 && y<5 && y>-5)
                {
                    //plot using drawline
                    g.DrawLine(Pens.Green,old_xx,old_yy,xx,yy);
                }
                old_xx = xx;
                old_yy = yy;
            }
        }
    }
}
