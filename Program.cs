using ATM1;

namespace ATMmachine
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = 5000;
            double withdraw;
            double deposit;
            double nBalance;
            string balanceEnquiry;
            string select;
            string input;
            



            Messages.MessageMethod(0);
            input = Console.ReadLine();
            Console.WriteLine(input);
            Console.WriteLine();

            Messages.MessageMethod(1);
            Console.WriteLine();
            Messages.MessageMethod(4);
            Messages.MessageMethod(5);
            Messages.MessageMethod(6);
            Messages.MessageMethod(7);
            Console.WriteLine();
            Console.Write("Select here;");

            select = Console.ReadLine();
            Console.WriteLine();

            if (select == ("w") || select == ("W"))
            {
                Messages.MessageMethod(8);
                withdraw = double.Parse(Console.ReadLine());
                nBalance = balance -= withdraw;
                Console.Write("New Balance: $ " + balance);
            }
            else if (select == ("d") || select == ("D")) 
            {
                Messages.MessageMethod(9);
                deposit = double.Parse(Console.ReadLine());
                nBalance = balance += deposit;
                Console.WriteLine("New Balance: $ " + balance);
            }
            else if (select == ("i") || select == ("I"))
            {
                Messages.MessageMethod(7);
                balanceEnquiry = Console.ReadLine();
                Console.Write("Your balance is: " + balance);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Sorry, there was an error, try again!!!");
            }
        }

    }
}
