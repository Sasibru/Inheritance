using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
	public class Manager : Person
	{
        public Manager(string name) : base(name)
        {
            //Intentionally left blank
        }

        public override void Contact() 
        {
            Console.WriteLine($"Sending emal to {Name} (as Manager class).");
        }
    }
}
