using System;
using System.Collections.Generic;
using System.Text;

namespace MoreAnimals.Library
{
   public class Eagle : ABird
    {
        public override void MakeNoise()
        {
            Console.WriteLine("REEEEEEEEEEEEEEEEEEEEEEEEEEE");
        }

        public override void GoTo(string location)
        {
            Console.WriteLine($"I'm an eagle, flying to {location}");
        }
    }
}
