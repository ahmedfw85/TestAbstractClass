using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAbstractClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circle c = new Circle();
            label1.Text = "Circle Area= " + c.CalcArea().ToString();

            Rectangle r = new Rectangle();
            label2.Text = "Rectangle Area= " + r.CalcArea().ToString();
        }
    }
}
