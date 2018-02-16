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
    public partial class FinalForm : Form
    {
        public FinalForm(bool toomuch)
        {
            InitializeComponent();
            if (!toomuch)
            {
                label2.Text = "You wanted it WAY too much, Try Again Next Time";

            }
            else
            {
                label2.Text = "You wanted it WAY too much, Try Again Next Time";

            }
            button1.Click += Exit;

        }
        private void Exit(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
