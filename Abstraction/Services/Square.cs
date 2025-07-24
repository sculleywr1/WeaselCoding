using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Services
{
    public class Square : IShape, IBehavior
    {


        //if you do not implement the interface methods, the compiler will throw an error. This is because the class does not fulfill the contract defined by the interface.
        //implementing the Draw method from the IShape interface
        public void Draw(int numberOfSides)
        {
            if (numberOfSides == 4)
            {
                Console.WriteLine("Drawing a square with 4 sides.");
            }
            else
            {
                Console.WriteLine("This shape is not a square.");
            }
        }

        public void grow(int howMuch)
        {

            if (howMuch > 0)
            {
                Console.WriteLine($"Growing the square by {howMuch} units.");
            }
            else
            {
                Console.WriteLine("Cannot grow the square by a non-positive amount.");
            }

        }
    }
}
