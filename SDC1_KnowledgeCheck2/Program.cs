using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDC1_KnowledgeCheck2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("How many stars do you want to add? ");
			var numberOfStars = int.Parse(Console.ReadLine());

			var starList = new List<Star>();
			for (int i = 0; i < numberOfStars; i++)
			{
				// In this loop, populate the object's properties using Console.ReadLine()
				var Star = new Star();

				Console.WriteLine("What is the name of the star?");
				Star.starName = Console.ReadLine();
				Console.WriteLine("Enter the value for star mass");
				Star.mass = Console.ReadLine();
				Console.WriteLine("Enter what the star is made of");
				Star.composition = Console.ReadLine();
				Console.WriteLine("Enter where the star is");
				Star.location = Console.ReadLine();
				Console.WriteLine("Enter the temperture of the star in degrees Kelvin");
				Star.degreesKelvin = Console.ReadLine();

				starList.Add(Star);

			}

			for (int i = 0; i < starList.Count; i++)
			{
                Console.WriteLine(starList[i].starName + ": " + starList[i].mass + " " + starList[i].composition + " " + starList[i].location + " " + starList[i].degreesKelvin);
			}

		}
	}
}


//Question for class - Ignore - Star.mass = Int32.TryParse(Console.ReadLine());
