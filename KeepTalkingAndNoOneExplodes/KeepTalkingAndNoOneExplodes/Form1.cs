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
    public partial class Form1 : Form
    {
        private double time;

        private Form2 win = new Form2();
        private LoseScreen loss;
        
        public Form1()
        {
            InitializeComponent();
            button1.Click += WireClick;
            button2.Click += WireClick;
            button3.Click += WireClick;
            button4.Click += WireClick;
            button5.Click += WireClick;
            button6.Click += StartClick;
        }

        private void StartClick(object sender, EventArgs e)
        {
            time = 100;
            timer1.Start();
        }

        private void WireClick(object sender, EventArgs e)
        {
            Button tempButton = (Button)sender;
            if (tempButton.Name == button5.Name)
            {
                timer1.Stop();
                win.ShowDialog();
            }
            else
            {
                loss = new LoseScreen(tempButton.BackColor.ToString());
                loss.ShowDialog();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time -= 1;                
                
                progressBar1.Increment(1);
                
            }
            else
            {
                timer1.Stop();
                loss = new LoseScreen("time");
                loss.ShowDialog();
            }
        }
    }
}
