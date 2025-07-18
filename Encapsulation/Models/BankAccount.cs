namespace Encapsulation.Models
{
    public class BankAccount
    {

        //Private field 
        private float _balance;

        //Constructor to initialize the balance
        public BankAccount(float initialBalance)
        {
            _balance = initialBalance;
        }

        //Public method to deposit money
        public void Deposit(float amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }

            _balance += amount;
        }

        //Public method to withdraw money
        public void Withdraw(float amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return;
            }
            if (amount > _balance)
            {
                Console.WriteLine("Insufficient funds for this withdrawal.");
                return;
            }
            _balance -= amount;
        }

        //public getter to retrieve the balance
        public float GetBalance()
        {
            return _balance;
        }
    }
}
