﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MoreAnimals.Library
{
    public abstract class ABird:IAnimal
    {
        public int ID { get; set; }        
        public string Breed { get; set; }

        public abstract void MakeNoise();

        public virtual void GoTo(string location)
        {
            Console.WriteLine($"Flying to {location}");
        }

    }
}
