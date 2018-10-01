using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7Program
{
	class Pet
	{
		public string type;
		public string name;
		public string owner;
		public double weight;
		public Pet(string t, string n, string o, double w)
		{
			type = t;
			name = n;
			owner = o;
			weight = w;
		}
		public string getTag()
		{
			return ("If lost, call " + owner);
		}
	}
}
