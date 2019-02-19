using System;
using System.Collections.Generic;
using System.Text;

namespace MoreAnimals.Library
{
    public class Dog:IAnimal
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }

        public void MakeNoise()
        {
            Console.WriteLine("Woof!");
        }

        public void GoTo(string location)
        {
            Console.WriteLine($"Walking to {location}");
        }

        

       
    }
}
