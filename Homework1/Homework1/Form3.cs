using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1
{
    public partial class Form3 : Form
    {
        FinalForm end;
        public Form3()
        {
            InitializeComponent();
            button1.Click += Choice;
        }

        private void Choice(object sender, EventArgs e)
        {
            double number;
            if (double.TryParse(textBox1.Text, out number))
            {
                if (number < 10)
                {
                    end = new FinalForm(false);
                    end.ShowDialog();
                }
                else
                {
                    end = new FinalForm(true);
                    end.ShowDialog();
                }
            }
            else
            {
                textBox1.Text = "That's not a number";
            }
            
        }
    }
}
