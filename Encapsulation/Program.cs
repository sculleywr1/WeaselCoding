using Encapsulation.Models;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount(1000.00f);

            /*myAccount.balance = 500.00f;*/ // This line will cause a compile-time error because 'balance' is private

            Console.WriteLine("Initial Balance: " + myAccount.GetBalance()); // output: Initial Balance: 1000

            myAccount.Deposit(200.00f);
            Console.WriteLine("Balance after deposit: " + myAccount.GetBalance()); // output: Balance after deposit: 1200

            myAccount.Withdraw(150.00f);
            Console.WriteLine("Balance after withdrawal: " + myAccount.GetBalance()); // output: Balance after withdrawal: 1050


        }
    }
}
