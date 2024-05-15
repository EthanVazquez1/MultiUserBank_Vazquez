using System.Numerics;

namespace MultiUserBank_Vazquez
{
    internal class Program
    {
            public static void Main(string[] args)
            {
            Bank Twinstar = new Bank();
            bool bankActive = true;
            
            string[] myUsers = { "jlennon", "pmccartney", "gharrison", "rstarr" };
            string[] myPass = { "johnny", "pauly", "georgy", "ringoy" };
            string Login = "";
            string passLogin = "";
            int userID = -1;
            bool isLoginValid = false;

            void logIn()
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to TwinStar. Please log in");
                    Console.WriteLine("The bank balance is " + Twinstar.GetBalance().ToString("C"));
                    Console.WriteLine("Type in your username");
                    Login = Console.ReadLine();


                    Console.WriteLine("Please enter your password");
                    passLogin = Console.ReadLine();
                    for (int i = 0; i < myUsers.Length; i++)
                    {
                        if (Login == myUsers[i])
                        {
                            if (passLogin == myPass[i])
                            {
                                isLoginValid = true;
                                userID = i;
                            }
                        }
                    }
                } while (!isLoginValid);
            }
            logIn();
                do
                {
                    Console.WriteLine("Hello " + Login);
                    //Console.WriteLine("The bank balance is " + Twinstar.GetBalance().ToString("C"));
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("Your options are: 1.Check balance  2.Deposit  3.Withdrawing  4.Log out");
                    string answer = Console.ReadLine();


                    if (answer == "1")
                    {
                    Console.WriteLine("Your current balance is " + Twinstar.GetuserBalance(userID).ToString("C"));
                    }

                    else if (answer == "2")
                    {
                    Console.WriteLine("How much would you like to deposit?");
                    string addinput = Console.ReadLine();
                    int addamount = int.Parse(addinput);
                    Twinstar.add(addamount, userID);
                    }

                    else if (answer == "3")
                    {
                    Console.WriteLine("How much would you like to withdrawl?");
                    string subtractinput = Console.ReadLine();
                    int subtractamount = int.Parse(subtractinput);
                    Twinstar.subtract(subtractamount, userID);
                    }

                    else if (answer == "4")
                    {
                         logIn();
                    }
                } while (bankActive);
            }
    }
}
