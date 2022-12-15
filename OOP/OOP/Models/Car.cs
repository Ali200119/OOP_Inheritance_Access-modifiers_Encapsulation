using System;
namespace OOP.Models
{
	public class Car
	{
		public string name;
		public string color;
		private int _horsePower;
		protected int maxSpeed;
		public int Year { get; set; }
		public int HorsePower
		{
			get
			{
				if (_horsePower > 100)
				{
					return _horsePower;
				}

				return -1;
			}

			set
			{
				_horsePower = value;
			}
		}


		public Car()
		{
			Console.WriteLine("Hello World");
		}

		public Car(string text):this()
		{
			Console.WriteLine(text);
		}

		public Car(int number, string test):this(test)
		{
			Console.WriteLine(number);
		}
	}
}