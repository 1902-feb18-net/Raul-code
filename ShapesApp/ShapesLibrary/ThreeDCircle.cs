﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
   public class ThreeDCircle: Circle,IDraw3D
    {
        //Circle supports IDraw3D
        public void Draw3D()
        {
            Console.WriteLine("Drawing Circle in 3D!");

        }
    }
}
