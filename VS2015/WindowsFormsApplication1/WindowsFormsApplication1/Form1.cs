using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //program が起動した際や，ウィンドウが隠れたのが戻った場合に呼び出されるメソッド．となる
        //InitializeComponent内をみるとこれはPaintEventHandler扱いになっていることがわかる．
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            String str1;
            int angle;
            double radian;
            //文字列は画像として扱われる．Form画面上への描画はGraphicsクラスのg.DrawString();
            g.DrawString("angle(deg)\tsin\t\tcos ",Font,Brushes.Black,10,20);
            g.DrawString("----------    ----------   -----------", Font, Brushes.Black, 10, 35);
            for (angle = 0; angle <= 90; angle += 10)
            {
                //you can use mathematical function sin and con by Math.Sin and Math.Cos respectively
                radian = angle * Math.PI / 180.0;
                str1 = string.Format("{0,3}\t\t{1,7:F5}\t\t{2,7:F5} ", angle, Math.Sin(radian), Math.Cos(radian));
                g.DrawString(str1, Font, Brushes.Black, 10, 50 + angle *2);
            }  
        }
    }
}
