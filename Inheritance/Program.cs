namespace Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog
            {
                Name = "Buddy",
                Age = 3
            };
        }
    }

    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Region { get; set; } = "Unknown";

        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a sound");
        }
        public virtual void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }

    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Woof! Woof!");
        }

        public void Fetch()
        {
            Console.WriteLine($"{Name} is fetching the ball!");
        }

        //this is a method that HIDES the base class method. Hiding is different from overriding in that it does not require the base method to be virtual or abstract. And it can stop this method from being overridden in derived classes.
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating dog food.");
        }
    }

    public class Doberman : Dog
    {
        public override void Speak()
        {
            Console.WriteLine("Bark! Bark!");
        }
        public void Guard()
        {
            Console.WriteLine($"{Name} is guarding the house.");
        }

        //the following method is commented out because it would override the base class method, but overriding is impossible because the base class method is not virtual or abstract.
        //public override void Eat()
        //{
        //    Console.WriteLine($"{Name} is eating premium dog food.");
        //}
    }

    //Composition Example

    public class Engine
    {
        public string Type { get; set; }
        public int HorsePower { get; set; }
        public void Start()
        {
            Console.WriteLine($"Engine of type {Type} with {HorsePower} HP started.");
        }
    }

    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public Engine? Engine { get; set; } // Composition: Car has an Engine. I can put as many classes as I want in this class, but I will only put one for now.
        public void Start()
        {
            Console.WriteLine($"Starting {Make} {Model}...");
            Engine.Start();
        }
    }
}
