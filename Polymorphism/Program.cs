namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Speak(); // Calls the overridden Speak method in Dog class
            //Dog specificDog = new Dog();
            //specificDog.Speak(1); // Calls the overloaded Speak method in Dog class 
            //specificDog.Speak(2); // Calls the overloaded Speak method in Dog class
            //specificDog.Speak(3); // Calls the overloaded Speak method in Dog class

            Doberman myDoberman = new Doberman();
            myDog.Guard(); // Calls the Guard method in Dog class
            myDoberman.Guard(); //calls the inherited Guard method in Dog class
            myDoberman.Guard(1); // Calls the overloaded Guard method in Doberman class and then goes through the switch statement
        }

        //typically all classes are defined in their own files, but for simplicity, we will define them here. Because they are in different files, the compiler won't notice overloading issues until runtime. This is because overloading is resolved at compile time, but the method that gets executed is determined at runtime based on the actual object type. this is why you need to be careful when using polymorphism, especially with method overloading across different classes.
        public class Animal
        {
            //virtual allows derived classes to override this method
            public virtual void Speak()
            {
                Console.WriteLine("Animal makes a sound");
            }
        }
        public class Dog : Animal
        {
            //override allows this method to replace the base class implementation
            public override void Speak()
            {
                Console.WriteLine("Woof! Woof!");
            }
            public void Speak(int situation)
            {
                //this method is overloaded, it has the same name as the base class method but with a different parameter
                switch (situation)
                {
                    case 1:
                        Console.WriteLine("Bark! Bark!");
                        break;
                    case 2:
                        Console.WriteLine("Woof! Woof!");
                        break;
                    case 3:
                        Console.WriteLine("Yelp! Yelp!");
                        break;
                    default:
                        Console.WriteLine("Dog is silent.");
                        break;
                }



            }

            public void Guard()
            {
                Console.WriteLine("Dog is guarding the house.");
            }

        }

        public class Doberman : Dog
        {
            //this method overrides the base class method
            public override void Speak()
            {
                Console.WriteLine("Bark! Bark!");
            }
            public void Guard(int situation)
            {
                //this method is overloaded, it has the same name as the base class method but with a different parameter
                switch (situation)
                {
                    case 1:
                        Console.WriteLine("Doberman is guarding");
                        break;
                    case 2:
                        Console.WriteLine("Doberman is attacking");
                        break;
                    case 3:
                        Console.WriteLine("Doberman is retreating");
                        break;
                }
            }

            public int Guard()
            {
                return 1; // Just an example to return an integer value
            }
        }
    }
}
