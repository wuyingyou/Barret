using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalePlatform
{
    public class Car
    {
		public String Name { get; set; }
		public decimal Length { get; set; }
		public decimal Width { get; set; }
		public decimal Price { get; set; }
		public void Drive()
		{
			for (int i = 0; i < 30; i++)
			{
				System.Threading.Thread.Sleep(1000);
			}
		}
    }
}
