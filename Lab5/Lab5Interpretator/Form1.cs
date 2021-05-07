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
        Context context = new Context();
        IExpression expr;
        DateTime _dateTime;
        float _deltaTime = 1f;
        bool _checked = true;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            _dateTime = DateTime.Now;
            //thread = new Thread(blabla);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            _dateTime = DateTime.Now;

            textBox2.Text = textBox2.Text + ".";
            _checked = false;



        }

        private void blabla()
        {
            
            expr = context.Evaluate(textBox1.Text);
            string tb2 = expr.intepret();
            //textBox2.Text = tb2;
            textBox2.Invoke((Action)delegate
            {
                textBox2.Text = tb2;
            });
            _checked = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Thread myThread = new Thread(new ThreadStart(blabla));
            Debug.WriteLine((DateTime.Now - _dateTime).TotalSeconds);
            if ((DateTime.Now - _dateTime).TotalSeconds > _deltaTime && !myThread.IsAlive && !_checked)
            {
                //myThread = new Thread(new ThreadStart(blabla));
                myThread.Start();
            }
        }
    }
}
