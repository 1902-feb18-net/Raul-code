using System;
using System.Collections.Generic;
using System.Text;

namespace MoreAnimals.Library
{
    public interface IAnimal
    {
        int ID { get; set; }
        string Breed { get; set; }
        void MakeNoise();
        void GoTo(string location);
    }
}
