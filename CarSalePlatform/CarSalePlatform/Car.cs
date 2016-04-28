using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalePlatform
{
    public class Car
    {
		public Car(string name)
		{
			Name = name;
		}

		public String Name { get; set; }


		public string Drive()
		{
			return Name + "is Driving";
		}
    }
}
