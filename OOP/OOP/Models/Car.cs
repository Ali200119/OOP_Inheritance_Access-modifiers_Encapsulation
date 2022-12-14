using System;
namespace OOP.Models
{
	public class Car
	{
		public string name;
		public string color;

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