namespace TestingGround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter your age: ");
            //string? input = Console.ReadLine();
            /*int age = int.TryParse(input, out int parsedAge) ? parsedAge : 0*/;
            //int age;
            //if (!int.TryParse(input, out age))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number.");
            //    return;
            //}
            //if (age >= 18)
            //{
            //    Console.WriteLine("You are an adult.");
            //}
            //else
            //{
            //    Console.WriteLine("You are not an adult yet.");
            //}
            //Console.WriteLine("Thank you for using the program!");

            // This is a simple program to determine ticket prices based on age
            //first we will ask the user for their age
            //Console.Write("enter your age: ");
            //// Read the input from the console. The question mark indicates that the input can be null. Console.ReadLine() returns a string or null if no input is provided.
            //String? input = Console.ReadLine();
            //// We will use int.TryParse to convert the input string to an integer. If the conversion fails, we will set age to 0. Alternatively, we could handle the case where the input is not a valid number by using a try-catch block, but here we will use int.TryParse for simplicity.
            //int age = int.TryParse(input, out int parsedAge) ? parsedAge : 0;
            /* if (!int.TryParse(input, out age))
                    {
                        Console.WriteLine("Invalid input. Please Enter a valid Number");
                        return;
                    } */

            // Now we will check the age and determine the ticket price based on the following rules:
            // 1. If the age is less than 18, the ticket price is $10.
            // 2. If the age is 18 or older, the ticket price is $20.
            // 3. If the age is 65 or older, the ticket price is $15.
            // 4. If the age is 5 or younger, the ticket is free.
            // 5. If the age is greater than 120, we will consider the input invalid.
            //if (age < 18)
            //{
            //    Console.WriteLine("your ticket is 10$");
            //}

            //else if (age >= 18)

            //{
            //    Console.WriteLine("your ticket is 20$");
            //}


            //else if (age >= 65)

            //{
            //    Console.WriteLine("your ticket is 15$");
            //}


            //else if (age <= 5)

            //{
            //    Console.WriteLine("your ticket is free");
            //}

            //else if (age > 120)

            //{
            //    Console.WriteLine("input invalid");
            //}

            //else

            //{
            //    Console.WriteLine("input invalid");
            //}
            //Console.WriteLine("thank you for using the program");

            //int choice = 2;

            //// This is a simple switch statement to demonstrate how to use it in C#. These are used for DISCRETE values, meaning that the variable can only take on one of a set of specific values.
            //switch (choice)
            //{
            //    case 1:
            //        Console.WriteLine("You chose option 1.");
            //        break;
            //    case 2:
            //        Console.WriteLine("You chose option 2.");
            //        break;
            //    case 3:
            //        Console.WriteLine("You chose option 3.");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid choice. Please select a valid option.");
            //        break;
            //}
            //break brings us out of the switch statement to this point in the code.

            //string day = "Monday";
            ////This is an example of how Switch statements use DISCRETE values, meaning that the variable can only take on one of a set of specific values. Strings are always DISCRETE values, so we can use them in a switch statement.
            //switch (day)
            //{
            //    case "Monday":
            //        Console.WriteLine("It's Monday, the start of the week! May the gods have mercy on our souls");
            //        break;
            //    case "Tuesday":
            //        Console.WriteLine("It's Tuesday, the second day of the week. I'm doing a bit better!");
            //        break;
            //    case "Wednesday":
            //        Console.WriteLine("It's Wednesday, the middle of the week. We're halfway there! WHOA Living on a prayer!");
            //        break;
            //    case "Thursday":
            //        Console.WriteLine("It's Thursday, the fourth day of the week. Almost there!");
            //        break;
            //    case "Friday":
            //        Console.WriteLine("It's Friday, gonna get down on Friday");
            //        break;
            //    case "Saturday":
            //        Console.WriteLine("It's Saturday, the weekend is here! Time to relax and enjoy!");
            //        break;
            //    case "Sunday":
            //        Console.WriteLine("It's Sunday, the last day of the week. Time to prepare for the upcoming week.");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid day. Please enter a valid day of the week. Or do you exist in a completely new calendar?");
            //        break;
            //}

            //the while loop is a control flow statement that allows code to be executed repeatedly based on a given boolean condition. The while loop can be thought of as a repeating if statement.

            int counter = 1;
            while (counter <= 5)
            {
                // This will print the current iteration number to the console. The dollar sign ($) before the string allows for string interpolation, which means we can include variables directly in the string by enclosing the variable name inside the curly brackets.
                Console.WriteLine($"This is iteration number {counter}");
                // The counter is incremented by 1 in each iteration of the loop. This is necessary to avoid an infinite loop, as the condition will always be true if the counter is not incremented.
                counter++;
            }

            for (int i = 1; i <= 5; i++)
            {
                // This will print the current iteration number to the console. The dollar sign ($) before the string allows for string interpolation, which means we can include variables directly in the string by enclosing the variable name inside the curly brackets.
                Console.WriteLine($"This is iteration number {i}");
            }

            string playAgain;
            //do statements are used to execute a block of code at least once, and then repeat the execution as long as a specified condition is true. The do statement is often used when you want to ensure that the code inside the block is executed at least once before checking the condition.
            do
            {
                Console.WriteLine("Playing the game...");
                Console.Write("Do you want to play again? (yes/no): ");
                //The question mark (?) after Console.ReadLine indicates that the method can return null, which is a common practice in C# to handle cases where no input is provided. The ToLower() method is used to convert the input to lowercase, making the comparison case-insensitive.
                playAgain = Console.ReadLine()?.ToLower();

            } while (playAgain == "yes" || playAgain == "y");
        }
    }
}
