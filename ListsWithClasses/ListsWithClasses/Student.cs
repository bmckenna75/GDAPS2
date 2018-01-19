using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsWithClasses
{
	class Student
	{

		//fields
		private string fullName;
		public string FullName
		{
			get { return fullName; }
			set { fullName = value; }
		}
		private string major;
		public string Major
		{
			get { return major; }
			set { major = value; }
		}
		private int birthyear;
		public int Birthyear
		{
			get { return birthyear; }
		}

		//constructor
		public Student(string name, string maj, int byear)
		{
			fullName = name;
			major = maj;
			birthyear = byear;
		}
		public Student()
		{
			fullName = "Non-Specified Name";
			major = "Undeclared";
			birthyear = 1900;
		}

		//methods 

		public override string ToString()
		{
			return "--Student--\nName: " + fullName + "\nMajor: " + major + "\nYear: " + birthyear;
		}



	}
}
