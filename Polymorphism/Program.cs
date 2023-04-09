﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //              Creatures
            //                  |
            //        Plants                      Animals
            //   |              |               |          |
            // WithSeeds   WithoutSeeds      Reptile     Birds

            PlantWithSeeds plantWithSeeds = new PlantWithSeeds();
            //plantWithSeeds.Feed(); // you can't access this method because(Creatures) it is protected and there is 2 level inheritance inside. You can only access inside a constructor class.
            plantWithSeeds.aspiration();
            plantWithSeeds.excretion();
            //This is override method. 
            plantWithSeeds.ReactionBehaviour();
            //plantWithSeeds.Photosynthesis(); : you can't access this method because(Plants) it is protected and you can only access inside a constructor class.
            plantWithSeeds.Seeded();
            Console.WriteLine("*************************************");
            Birds birds = new Birds();
            birds.Adaptation();
            birds.aspiration();
            birds.BirdsFly();
            birds.ReactionBehaviour();
            //birds.Feed(); // you can't access this method because(Creatures) it is protected and there is 2 level inheritance inside. You can only access inside a constructor class.
            birds.excretion();
            Console.ReadLine();
        }
    }
}
