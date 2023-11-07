using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
	public class Teacher : Person
	{
		List<string> Courses { get; set; }
		public Teacher(string name) : base(name) 
		{
			Courses = new();
		}

		public override void Contact()
		{
			//base.Contact();
            Console.WriteLine("Sending linkedin message to teacher.");
        }

		public void ChangeSalary(int salary)
		{

		}
	}
}
