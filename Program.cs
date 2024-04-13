using System;
using UserAccountBusiness;

namespace AccountSystemUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ENTER EMAIL: ");
            string email = Console.ReadLine();

            Console.Write("ENTER PASSWORD: ");
            string password = Console.ReadLine();

            UserBusiness user = new UserBusiness(); 
            bool result = user.VerifyUser(email, password);

            if(result)
            {
                Console.WriteLine();
                Console.WriteLine("SUCCESSFUL!!!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("FAILED!!!");
            }

        }
    }
}
