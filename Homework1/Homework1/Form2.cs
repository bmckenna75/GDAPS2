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
    public partial class Form2 : Form
    {
        Form3 doYouReallyWantIt;
        public Form2()
        {
            doYouReallyWantIt = new Form3();
            InitializeComponent();
            menuBar.ItemClicked += HowSure;
        }
        private void HowSure(object sender, EventArgs e)
        {
            doYouReallyWantIt.Show();
        }
        

    }
}
