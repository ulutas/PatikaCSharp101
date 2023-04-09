using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animals : Creatures
    {

        public void Adaptation()
        {
            Console.WriteLine("Animals adapt.");
        }


    }

    public class Reptile : Animals
    {

        public void ReptileColdBlood()
        {
            Console.WriteLine("Reptile has a cold blood.");
        }

    }



    public class Birds : Animals
    {
        public void BirdsFly()
        {
            Console.WriteLine("Birds fly.");
        }
    }
}
