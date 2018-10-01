using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7Program
{
	class Dog : Pet
	{
		public Dog(string n, string o, double w) : base("Dog", n, o, w)
		{
		}
		public string Bark(int count)
		{
			string line = "";
			while (count > 0)
			{
				line = line + "Bark!";
				count--;
			}
			return line;
		}
	}
}