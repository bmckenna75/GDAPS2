using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsWithClasses
{
	class Roster
	{
		//fields
		List<Student> ClassRoster;

		//constuctor
		public Roster()
		{
			ClassRoster = new List<Student>();
		}

		//methods 
		public void AddStudent()
		{
			Console.WriteLine("Please enter full name:");
			string studentName = Console.ReadLine();
			Console.WriteLine("Please enter major:");
			string studentMaj = Console.ReadLine();
			Console.WriteLine("Please enter birthyear:");
			int studentBirthyear = int.Parse(Console.ReadLine());
			ClassRoster.Add(new Student(studentName, studentMaj, studentBirthyear));
			Console.WriteLine(studentName + " has been added...");
		}
		public void AddStudent(string name, string maj, int byear)
		{
			ClassRoster.Add(new Student(name, maj, byear));
			Console.WriteLine(name + " has been added...");
		}
		public bool SearchByName()
		{
			Console.WriteLine("What is the name of the student to find?");
			string studentName = Console.ReadLine();
			foreach ( Student s in ClassRoster)
			{
				if (s.FullName.Trim().ToUpper() == studentName.Trim().ToUpper())
				{
					Console.WriteLine(s.ToString());
					return true;
				}
			}
			return false;
		}
		public bool SearchByName(string studentName)
		{
			foreach (Student s in ClassRoster)
			{
				if (s.FullName.Trim().ToUpper() == studentName.Trim().ToUpper())
				{
					Console.WriteLine(s.ToString());
					return true;
				}
			}
			return false;
		}
		// Did you really name your son Robert'); DROP TABLE Students;--?
		public void RemoveStudents()
		{
			Console.WriteLine("What is the name of the student to drop?");
			string studentName = Console.ReadLine();
			if (SearchByName(studentName) == true)
			{
				for (int i = 0; i < ClassRoster.Count; i++)
				{
					if (ClassRoster[i].FullName.Trim().ToUpper() == studentName.Trim().ToUpper())
					{
						Console.WriteLine(ClassRoster[i].FullName + " Has been removed from the roster");
						ClassRoster.RemoveAt(i);
						return;
					}
				}
				Console.WriteLine(studentName + " can not be found and was not removed");
			}
		}
		public void DisplayRoster()
		{
			foreach (Student s in ClassRoster)
			{
				Console.WriteLine(s.ToString());
			}
		}
		public void DisplayMajor()
		{
			Console.WriteLine("What major would you like to view?");
			string studentMaj = Console.ReadLine();
			foreach (Student s in ClassRoster)
			{
				if (s.Major.Trim().ToUpper() == studentMaj.Trim().ToUpper())
				{
					Console.WriteLine(s.ToString());
				}
			}
		}


	}
}
