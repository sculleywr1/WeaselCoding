using System.Net.Security;

namespace HelloWorld
{
    internal class Program
    {
        // dotnet run -- args
        //dotnet run -- arg1 arg2 arg3 "hello world"
        //[0] = arg1, [1] = arg2, [2] = arg3 ... 
        public static void Main()
        {         

            int railcarKeyId = 3;
            int b = 5;
            string c = "2";
            int d = 4;
            //System.Console.WriteLine(a + b + c + d);

            float e = 5.1234567f;
            double f = 6.123456789012345;
            //System.Console.WriteLine(a + e);
            //System.Console.WriteLine(g);

            bool isTrue = false;

            char myChar = 'A';
            string myString = "spaghetti makes good strings";

            int myInt = 42;
            int myInt2 = 404;

            int myInt3 = myInt + myInt2;
            int myInt4 = myInt3 * 2;
            int myInt5 = myInt4 - 10;
            int myInt6 = myInt5 / 2;
            int myInt7 = myInt6 % 4;
            //System.Console.WriteLine(myInt3);
            //System.Console.WriteLine(myInt4);
            //System.Console.WriteLine(myInt5);
            //System.Console.WriteLine(myInt6);
            //System.Console.WriteLine(myInt7);
            /* 
             
             */

            //System.Console.WriteLine(myInt == 43);

            string myString2 = "Hello, World!";
            string myString3 = new string("hello, World!");

            //System.Console.WriteLine(myString2 == myString3);

            int year = 2025;
            string bootCamp = "Weasel Coding";




            string fullString = $"In {year}, we are attending {bootCamp}!";

            System.Console.WriteLine(fullString);

            if (fullString == "")
            {
                fullString = "This string was empty";
            }
            else if (year == 2025)
            {
                System.Console.WriteLine(" We don't need to hear the same thing twice.");
                fullString += " And this string was not empty. We are in condition 2.";
            }
            else
            {
                fullString += " And this string was not empty";
            }

            if (fullString.GetType() == typeof(string))
            {
                System.Console.WriteLine("This is a string");
            }

            System.Console.WriteLine(fullString);

            int choice = 2;
            switch (choice)
            {
                case 1:
                    System.Console.WriteLine("You chose 1");
                    break;
                case 2:
                    System.Console.WriteLine("You chose 2");
                    break;
                case 3:
                    System.Console.WriteLine("You chose 3");
                    break;
                default:
                    System.Console.WriteLine("You did not choose 1, 2, or 3");
                    break;
            }

            if (choice > 1 && choice < 4)
            {
                System.Console.WriteLine("You chose a number between 1 and 4");
            }

            byte myByte = 0b0000_0001; // 1

            string choiceString = choice.ToString();

            int person1 = 1;
            int person2 = 5;
            int person3 = 17;
            int person4 = 40;
            int person5 = 65;


            int[] people = { person1, person2, person3, person4, person5 };
            int numberOfPeople = people.Length; // 5


            for (int i = 0;
                i < numberOfPeople;
                i++)
            {
                System.Console.WriteLine($"Person {i + 1} is {people[i]} years old and their ticket price is {ReturnPrice(people[i])}");
            }

            int counter = 0;
            while (counter < numberOfPeople)
            {
                System.Console.WriteLine($"Person {counter + 1} is {people[counter]} years old and their ticket price is {ReturnPrice(people[counter])}");

                /*
                 *  if (person is a student)
                 *      { add tally to the list of students attended today and now increment counter
                 * 
                 */
            }






        }

        public static string ReturnPrice(int age)
        {
            switch (age)
            {
                case <= 5:
                    return "Nothing";
                case < 18:
                    return "$5.00";
                case > 65:
                    return "$7.00";
                default:
                    return "$10.00";
            }
        }

        //put logic to multiply the return price by modifiers
        
    }
}
