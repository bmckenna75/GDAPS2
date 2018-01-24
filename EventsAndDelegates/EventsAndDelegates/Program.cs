using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
	//delegate
	delegate void MessageDelegate(string label, string message);
	class Program
	{
		static void Main(string[] args)
		{
			Log MessageLog = new Log();
			Die Roller = new Die();

			Roller.RolledATwenty += MessageLog.Save;


			for (int i = 0; i < 100; i++)
			{
				Roller.Roll();
			}

			MessageLog.Print();



		}
	}
}
