using System;
using MoreAnimals.Library;

namespace MoreAnimals.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var fido1 = new Dog();
            fido1.ID = 1;
            fido1.Name = "Fido";
            fido1.Breed = "Doberman";

            var fido2 = new Dog()
            {
                ID = 2,
                Name = "Fido",
                Breed = "DoberMan"

            };

            fido1.GoTo("park");
            fido1.MakeNoise();

            IAnimal animal = fido1;
            Dog dsdf = (Dog)animal;
            //Bird twdsf = (Bird)animal;
            int integer = (int)3.5;
            Console.WriteLine(integer);
            Console.WriteLine("**********************");

            var animals = new IAnimal[2];
            animals[0] = fido1;
            animals[1] = new Eagle()
            {
                ID = 1,
                Breed = "ere2e"
                
            };
            foreach (var item in animals)
            {
                Console.WriteLine(item.Breed);
                item.MakeNoise();
                item.GoTo("park");
            }
            Console.ReadLine();



        }
    }
}
