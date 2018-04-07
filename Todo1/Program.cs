using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo1
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Add a task");
			TodoItem todo = new TodoItem();

			todo.Name = Console.ReadLine();

		}
	}
}
