using System;
namespace OOP.Models
{
	public class Animal
	{
		public string name;

        public Animal(bool isHomePet, string name)
        {
            if (isHomePet)
            {
                Console.WriteLine($"{name} is a home pet");
            }

            else
            {
                Console.WriteLine($"{name} isn't a home pet");
            }
        }

        public void Sound(string name)
        {
            Console.WriteLine($"{name} animal's sound");
        }
    }
}

