using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5Interpretator
{
    public partial class Form1 : Form
    {

 
        public Form1()
        {
            InitializeComponent();
            //thread = new Thread(blabla);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            blabla();
            

      
        }

        private void blabla()
        {
            Context context = new Context();
            IExpression expr = context.Evaluate(textBox1.Text);
            string tb2 = expr.intepret();

            textBox2.Invoke((Action)delegate

            {

                textBox2.Text = tb2;

            });
        }
    }
}
