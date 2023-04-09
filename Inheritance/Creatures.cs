using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Creatures
    {

        protected void Feed()
        {
            Console.WriteLine("Creatures feed.");
        }

        public void aspiration()
        {
            Console.WriteLine("Creatures aspirate.");
        }

        public void excretion()
        {
            Console.WriteLine("Creatures excrete.");
        }

    }
}
