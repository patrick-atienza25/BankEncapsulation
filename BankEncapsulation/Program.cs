namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.Deposit(1000);
            Console.WriteLine($"Your deposit of {account.GetBalance()} is in your account.");
        }
    }
}
