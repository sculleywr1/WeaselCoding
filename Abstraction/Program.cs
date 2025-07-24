using Abstraction.Models;
using Abstraction.Services;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This implements the Animal Class downcasting to Dog class allowing the abstract method Speak to be called in the concrete Dog class.
            Animal myAnimal = new Dog();

            myAnimal.Speak(); // Outputs: Woof! Woof!
            myAnimal.Guard(); // Outputs: Animal is guarding its territory.


            //in the code you can see that the IShape interface is implemented by the Square class, which defines the Draw method. however, the front-end code does not need to know the details of how the square is drawn, it just needs to call the Draw method with the appropriate number of sides. It doesn't even need to know that the shape is a square, it just knows it can call Draw on any object that implements the IShape interface.
            IShape shape = new Square();
            shape.Draw(4); // Outputs: Drawing a square with 4 sides.
            // The Square class also implements the IBehavior interface, which defines the grow method. This allows the Square class to have additional behavior without affecting the IShape interface. 
            //the below code cannot work because the IShape interface does not define the grow method, so it cannot be called on an IShape reference. If we need that part of the functionality, we need to cast the shape to the Square type or use a different reference type that includes the grow method.
            //shape.grow(4);

            // To use the grow method, we need to cast the shape to the Square type under ibehavior interface or as a Square type directly.
            IBehavior squareBehavior = new Square();
        }
    }
}
