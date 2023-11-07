namespace InheritanceApp
{
	internal class Program
	{
		static void Main()
		{
			List<Person> persons = new()
			{
			new Manager("Madeleine"),
			new Teacher("Tomas"),
			};

			foreach(Person person in persons)
			{
				person.Contact();
			}
			
			//Teacher teacher = new("Anders");
			//teacher.ChangeSalary(1);


		}
	}
}