
namespace WeaselCodingLessons
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string color = "Red";
            int year = 2020;
            //this line reates an instance of the Car class without any information about the car
            Car myCar = new Car
            {

                Color = color,
                Year = year

            };
            //this line sets the color of the car to red


            //this line sets the year of the car to 2020
            myCar.Year = 2020;

            //this line calls the Honk method on the myCar instance
            myCar.Honk();

        }
    }

    public class Car
    {
        //properties of the Car class
        public required string Color { get; set; }
        public int Year;

        public void Honk()
        {
            Console.WriteLine($"Honk! Honk! My car is {Color} and it was made in {Year}");
        }
    }
}