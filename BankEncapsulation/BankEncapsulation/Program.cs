namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[]args)
        {
            BankAccount userAccount = new BankAccount();
            
            Console.WriteLine("Enter a dollar amount to deposit:");

            double userDeposit = double.Parse(Console.ReadLine());

            userAccount.Deposit(userDeposit);

            Console.WriteLine($"Your balance is: $"+ (userAccount.GetBalance()));
        }
    }
}
