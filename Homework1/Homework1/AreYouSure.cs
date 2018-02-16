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
    public partial class AreYouSure : Form
    {
        private Form2 Adjuster;
        public AreYouSure()
        {
            InitializeComponent();
            Random rnjesus = new Random();
            Adjuster = new Form2();
            List<Button> buttons = new List<Button>();
            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button2);
            for (int i = 0; i < 3; i++)
             {
                int currentButton = rnjesus.Next(0, 3 - i);
                if (i == 0)
                {
                    buttons[currentButton].Click += Next;
                    buttons[currentButton].Text = "Yes";
                    buttons.RemoveAt(currentButton);
                }
                if (i == 1)
                {
                    buttons[currentButton].Text = "Yes";
                    buttons[currentButton].Click += Psych;
                    
                    buttons.RemoveAt(currentButton);
                }
                if (i == 2)
                {
                    buttons[currentButton].MouseEnter += No;
                    buttons[currentButton].Text = "No";
                    buttons.RemoveAt(currentButton);
                }
            }

        }

        private void Next(object sender, EventArgs e)
        {
            Adjuster.Show();
        }

        private void Psych(object sender, EventArgs e)
        {
            Button tempButton = (Button)sender;
            tempButton.Text = "Psych!!!!!";
            System.Threading.Thread.Sleep(500);
            this.Close();
        }

        private void No(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
