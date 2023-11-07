using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
	public abstract class Person
	{
		public string Name { get; set; }
        string Email { get; set; }

        public Person(string name)
        {
            Name = name;
            Email = string.Empty;
        }

        //public virtual void Contact()
        //{
        //    Console.WriteLine($"Sending email to {Name}(from person class).");
        //}

        public abstract void Contact();
	}
}
