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
    public partial class Form1 : Form
    {

        AreYouSure areYouSure = new AreYouSure();
        public Form1()
        {
            InitializeComponent();
            button1.Click += VolumeClick;
        }

        private void VolumeClick(object sender, EventArgs e)
        {
            areYouSure.ShowDialog();
        }



    }
}
