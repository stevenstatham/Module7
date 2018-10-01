using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7Program
{
	class Cat : Pet
	{
		public Cat(string n, string o, double w) : base("Cat", n, o, w)
		{
		}
		public string Meow(int count)
		{
			string line = "";
			while (count > 0)
			{
				line = line + "Meow.";
				count--;
			}
			return line;
		}
	}
}