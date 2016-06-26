using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalc
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private enum ope
        {
            plus=0 ,
            minus,
            prod,
            quot,
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex =(int)ope.plus;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double a=0.0,b=0.0,c=0.0;
            try
            {
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show(ex.Message, "input error");
            }
            int indexNumber = comboBox1.SelectedIndex;
            switch (indexNumber)
            {
                case (int)ope.plus: c=a+b; break;
                case (int)ope.minus: c = a - b; break;
                case (int)ope.prod: c = a * b; break;
                case (int)ope.quot:
                if(b==0){
                    MessageBox.Show("input nonzero value");
                }
                else
                {
                    c = a / b;
                }
                    break;
            }
            label2.Text=c.ToString();
        }
    }
}
