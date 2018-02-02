using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeepTalkingAndNoOneExplodes
{
    public partial class LoseScreen : Form
    {
        public LoseScreen(string wireColor)
        {
            InitializeComponent();
            if (wireColor.StartsWith("Color"))
            {
                string tempText = wireColor;
                tempText = tempText.Remove(0, 7);
                tempText = tempText.Remove(tempText.Length - 1, 1);
                label2.Text = "You shouldn't have clicked the " + tempText + " button.";
            }
            else
            {
                label2.Text = "You ran out of time. Boom.";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
