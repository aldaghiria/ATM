namespace ATM;

class Program
{
    static void Main(string[] args)
    {
        double balance = 100;
        char selection;
        int withdraw = 0;
        double deposit;

        while (true)
        {

        //Display ATM Selection Menu
        Console.WriteLine("*********************");
        Console.WriteLine("Bank ATM");
        Console.WriteLine("[D] Deposit");
        Console.WriteLine("[W] Withdraw");
        Console.WriteLine("[B] Balance");
        Console.WriteLine("[X] Done");
        Console.WriteLine("*********************");

        Console.WriteLine("Please enter a numerical selection");

        //Get user's selection
         selection = Convert.ToChar(Console.ReadLine());


            if (selection.Equals('D') || selection.Equals('d'))
            {
                Console.WriteLine(" ");
                Console.WriteLine("Please enter the amount to be deposited.");
                
                Console.WriteLine("The amount must be between $0.01 and $500");

                deposit = Convert.ToDouble(Console.ReadLine());

                if (deposit >= 0.01 && deposit <= 500)
                {
                    balance = balance + deposit;
                    Console.WriteLine($"Deposit Successful. Your new balance  is {balance}");
                }

                else
                {
                    Console.WriteLine("Ivalid Amount");
                }
            }

            else if (selection.Equals('W') || selection.Equals('w'))
            {
                Console.WriteLine("Please enter the amount to be withdrawn.");
                withdraw = Convert.ToInt32(Console.ReadLine());

                if (withdraw > 0 && withdraw <= balance && withdraw % 10 == 0)
                {
                    balance = balance - withdraw;

                    Console.WriteLine($"Withdraw Successful. Your new balance is {balance}");

                }
                else if (withdraw <= 0)
                {
                    Console.WriteLine("Amount must be positive");
                }
                else if (withdraw > balance)
                {
                    Console.WriteLine("The amount to be withdrawn must be less or equal the balance");
                }
                else if (withdraw % 10 != 0)
                {
                    Console.WriteLine("Amount is not a mutliple of 10");
                }
            }

            else if (selection.Equals('B') || selection.Equals('b'))
            {
                Console.WriteLine($"Your balance is {balance}");
            }

            else if (selection.Equals('X') || selection.Equals('x'))
            {
                Console.WriteLine("Thank you for using our ATM");
                break;
            }

        
            else
            {
                Console.WriteLine("No valid choice has been entered");
            }

        }
    }
}
