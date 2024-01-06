namespace Exercise001
{
    using System;
    public class Program
    {

        public static void Main(string[] args)
        {

            // DO NOT TOUCH THE OTHER FILE!
            // Do your code here!
            Account zihadAccount = new Account("Zihad's account", 100.0);
            zihadAccount.Deposit(20.0);
            Console.WriteLine(zihadAccount.balance);
        }
    }
}