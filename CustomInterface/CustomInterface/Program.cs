using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ////Ack! Illegal to allocate interface types.
            //IPointy p = new IPointy();//Compiler erro!
            Console.WriteLine("****** Fun with Interfaces *****\n");
            //Call Points property defined by IPointy.
            Hexagon hex = new Hexagon();
            Console.WriteLine("Points: {0}", hex.Points);
            Console.WriteLine("*********");
            //Catch a possible InvalidCastException.
            Circle c = new Circle("Lisa");
            IPointy itfPt = null;
            try
            {
                itfPt = (IPointy)c;
                Console.WriteLine(itfPt.Points);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
            //Can we treat hex2 as Ipointy?
            Hexagon hex2 = new Hexagon("Peter");
            IPointy itfPt2 = hex2 as IPointy;

            if (itfPt2 != null)
                Console.WriteLine("Points: {0}", itfPt2.Points);
            else
                Console.WriteLine("OOP! Not pointy...");
            Console.WriteLine("****************************");
            //Makes an array of Shapes.
            Shape[] myShapes = { new Hexagon(), new Circle(), new Triangle("Joe"), new Circle("JoJo") };

            for(int i = 0; i < myShapes.Length; i++)
            {
                //Recall the Shape base class defines an abstract Draw()
                //member, so all shapes know how to draw themselves.
                myShapes[i].Draw();

                //Who's pointy?
                if(myShapes[i] is IPointy)
                    Console.WriteLine("-> Points: {0}",((IPointy)myShapes[i]).Points);
                else
                    Console.WriteLine("->{0}\'s not pointy!",myShapes[i].PetName);
                //Can I draw you in 3D?
                if (myShapes[i] is IDraw3D)
                    DrawIn3D((IDraw3D)myShapes[i]);
            }

            Console.WriteLine("******************");

            //Get First pointy item
            //To be safe, you'd want to check firstPointyItem for null before proceeding.
            IPointy firstPointyItem = FindFirstPointyShape(myShapes);
            Console.WriteLine("The item has {0} points", firstPointyItem);

            Console.ReadLine();
        }

        //This method returns the first object in the array that implements IPointy
        static void DrawIn3D(IDraw3D itf3d)
        {
            Console.WriteLine("-> Drawing IDraw3D compatible type");
            itf3d.Draw3D();
        }

        static IPointy FindFirstPointyShape(Shape[] shapes)
        {
            foreach (Shape s in shapes)
            {
                if (s is IPointy)
                    return s as IPointy;
            }
            return null;
        }
    }
}
