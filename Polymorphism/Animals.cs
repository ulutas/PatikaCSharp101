using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Animals : Creatures
    {

        public void Adaptation()
        {
            Console.WriteLine("Animals adapt.");
        }

        //We run this virtual method once. And after that we can modify.
        //This is a override method.
        public override void ReactionBehaviour()
        {
            base.ReactionBehaviour();
            Console.WriteLine("Animals bite when we touch their head.");
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
