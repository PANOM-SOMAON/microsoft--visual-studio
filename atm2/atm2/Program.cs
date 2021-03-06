using System;

namespace ATM
{
    public class Program
    {
        public static double balance = 9000;//ยอดเงิน

        static void Main()
        {
            string menu = "1 - View Balance\n2 - Withdraw\n3 - Deposit\n4 - Exit\n";
            string userSelection; //ตัวเลือกเมนู
            double menuController; //ส่วนควบคุม
            double amount = 0; //จำนวนเงิน ที่

            //ส่วนแรก
            Console.WriteLine("Welcome to banking.");

            while (true)
            {
                //Show menu
                Console.WriteLine("\nPlease select from the following menu(1, 2, 3, 4):");
                Console.WriteLine(menu);
                //Get user choice (try, catch error thrown from ValidateChoice and reprompt)
                userSelection = Console.ReadLine();
                try
                {
                    //Validate user choice
                    menuController = ValidateChoice(userSelection, true);
                }
                catch
                {
                    Console.WriteLine("\nInvalid Choice. Please select from the following menu:");
                    continue;
                }

                //If menuController == -1, reprompt
                if (menuController == -1)
                {
                    Console.WriteLine("\nMenu option not recognized. Please select again:");
                    continue;
                }

                //If choice is exit, exit
                if (menuController == 4)
                {
                    Console.WriteLine("\n\nThank you for banking with us. Goodbye!\n\n");
                    return;
                }

                //If choice is withdraw or add, get amount
                if (menuController == 2 || menuController == 3)
                {
                    string action = menuController == 2 ? "withdraw" : "deposit";
                    while (true)
                    {
                        Console.WriteLine($"\nPlease enter amount to {action}");
                        try
                        {
                            amount = ValidateChoice(Console.ReadLine(), false);
                            if (amount == -1)
                            {
                                Console.WriteLine("\nAmount not valid.\n");
                                continue;
                            }
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("\nInvalid amount.");
                            continue;
                        }
                    }
                }

                //Execute user choice
                switch (menuController)
                {
                    case 1:
                        ViewBalance();
                        break;
                    case 2:
                        Withdraw(amount);
                        break;
                    case 3:
                        Deposit(amount);
                        break;
                }
            }
        }

        //Validates user menu choice 
        //Returns the menu int if the menu parameter is true,
        //else returns the amount entered if menu is set to false
        //If the input is invalid (i.e., not convertible to an int)
        //then the method throws an error
        public static double ValidateChoice(string input, bool menu)
        {
            //Console.WriteLine("validateChoice called");
            double convertedInput;
            //Try to convert input to int
            try
            {
                convertedInput = Convert.ToDouble(input);
            }
            //Catch error, throw to main, and return with status of -1
            catch
            {
                throw;
            }
            finally
            {
                convertedInput = Convert.ToDouble(input);
            }
            //If the number is 1-4 and return with that number
            if (convertedInput > 0 && convertedInput < 5 && menu) return convertedInput;
            else if (convertedInput > 0 && !menu) return convertedInput;
            else return -1;
        }

        //Displays the balance
        public static void ViewBalance()
        {
            Console.WriteLine($"\nCurrent balance: ${balance}\n");
        }

        //Checks that withdrawal is possible, then withdraws amount chosen
        //returns 0 for success, -1 for error
        public static int Withdraw(double amount)
        {
            //Check that withdrawal is possible
            if (balance - amount <= 0)
            {
                Console.WriteLine("\n\nInsufficient Funds. Cannot complete transaction.\n\n");
                return -1;
            }
            else
            {
                balance = balance - amount;
                return 0;
            }
        }

        //Adds chosen amount to user balance.
        public static void Deposit(double amount)
        {
            balance = balance + amount;
            Console.WriteLine();
        }
    }
}