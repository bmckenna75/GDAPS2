using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsForms
{
    class MyForm : Form
    {
		Button[,] ButtonArray = new Button[10, 10];
		public MyForm()
		{
			this.Text = "Disco Simulator 2018";
			this.Size = new Size(1920, 1080);
			
			//begin button making loop

			for (int x = 0; x < 10; x++)
			{
				for (int y = 0; y < 10; y++)
				{
					ButtonArray[x, y] = new Button();
					Size tempSize = new Size(100, 100);
					ButtonArray[x, y].Size = tempSize;
					Point temp = new Point(x*100,y*100);
					ButtonArray[x, y].Location = temp;

					ButtonArray[x, y].MouseEnter += ButtonClickHandler;

					
					this.Controls.Add(ButtonArray[x, y]);
				}
			}
		}

		private void ButtonClickHandler(object sender, EventArgs e)
		{
			if (sender is Button)
			{
				Button b = (Button)sender;
				b.BackColor = Color.Purple;
			}
		}




    }
}
