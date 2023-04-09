﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Plants : Creatures
    {

        protected void Photosynthesis()
        {
            Console.WriteLine("Plants photosynthesize.");
        }

    }

    public class PlantWithSeeds : Plants
    {
        public PlantWithSeeds()
        {
            base.Photosynthesis(); // from plants
            base.Feed(); // from creatures. Double level inherit.
        }

        public void Seeded()
        {
            Console.WriteLine("plants reproduce by seeds.");
        }

    }

    public class PlantWithoutSeeds : Plants
    {
        public void Seeded()
        {
            Console.WriteLine("plants reproduce without seeds.");
        }
    }
}
