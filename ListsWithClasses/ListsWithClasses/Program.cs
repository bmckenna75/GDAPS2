using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsWithClasses
{
    class Program
    {
        static void Main(string[] args)
        {
			Roster Gdaps = new Roster();
			bool switcher = true;
			do
			{
				Console.WriteLine("Choose an option:\n1 - Add a student\n2 - Remove a student\n3 - Search for a student\n4 - Print the classlist\n5 - Print all students in a major\n6 - Quit");
				string options = Console.ReadLine();
				switch (options)
				{
					case "1":
						Gdaps.AddStudent();
						continue;
					case "2":
						Gdaps.RemoveStudents();
						continue;
					case "3":
						Gdaps.SearchByName();
						continue;
					case "4":
						Gdaps.DisplayRoster();
						continue;
					case "5":
						Gdaps.DisplayMajor();
						continue;
					case "6":
						switcher = false;
						continue;
					default:
						continue;
				}
			}
			while (switcher == true);
        }
    }
}
