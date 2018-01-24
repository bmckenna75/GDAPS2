using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
	
	class Die
	{
		//fields
		private Random dice;
		private int rollCount;
 
		//constructor
		public Die()
		{
			dice = new Random();
			rollCount = 0;
		}

		//event
		public event MessageDelegate RolledATwenty;

		//method
		public void Roll()
		{
			rollCount++;
			int rollValue = dice.Next(1, 21);
			Console.WriteLine("Rolling..." + rollValue);
			if (rollValue == 20) { RolledATwenty("Rolled a 20", "This was roll number "+ rollCount); }

		}
	}
}
