using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo1
{
	class TodoItem
	{

		private string name;
		private bool done; 

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public bool Done
		{
			get { return done;  }
			set { done = value;  }
		}

	}
}
