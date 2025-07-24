using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Models
{
    public abstract class Animal
    {
        //this method is abstract, meaning derived classes must implement it
        public abstract void Speak();

        public virtual void Guard()
        {
            Console.WriteLine("Animal is guarding its territory.");
        }

    }
}
