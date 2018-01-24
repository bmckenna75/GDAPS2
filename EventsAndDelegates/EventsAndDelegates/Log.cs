using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
	class Log
	{
		//fields
		private List<string> label;
		private List<string> message;

		//constructor 
		public Log()
		{
			label = new List<string>();
			message = new List<string>();
		}

		//methods
		public void Save(string lab, string mess)
		{
			label.Add(lab);
			message.Add(mess);
		}
		public void Print()
		{
			for ( int i = 0; i < label.Count; i++)
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write(label[i]);
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine(": " + message[i]);
				Console.ForegroundColor = ConsoleColor.Gray;
			}
		}
	}
}
