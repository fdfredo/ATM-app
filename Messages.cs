using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM1
{
    public class Messages
    {
        const string userMessage = "Welcome, please insert your card";
        const string successful = "Card inserted successfully";
        const string insufficient = "Insufficient balance";
        const string goodBye = "Thank you for banking with us";
        const string selectT = "Select your transaction";
        const string withdrawal = "w for withdrawal";
        const string deposit = "d for transfer";
        const string balanceEnquiry = "i for balance enquiry";
        const string amount1 = "Enter the amount you want to withdraw; $";
        const string amount2 = "Enter the amount you want to deposit; $";


        public static void MessageMethod(short? MessageIndex, string? result = null)
        {
            switch (MessageIndex)
            {
                case 0:
                    Console.WriteLine(userMessage);
                    break;
                case 1:
                    Console.WriteLine(successful);
                    break;
                case 2:
                    Console.WriteLine(insufficient);
                    break;
                case 3:
                    Console.WriteLine(goodBye);
                    break;
                case 4:
                    Console.WriteLine(selectT);
                    break;
                case 5:
                    Console.WriteLine(withdrawal);
                    break;
                case 6:
                    Console.WriteLine(deposit);
                    break;
                case 7:
                    Console.WriteLine(balanceEnquiry);
                    break;
                case 8:
                    Console.WriteLine(amount1);
                    break;
                case 9:
                    Console.WriteLine(amount2);
                    break;
            }
        }
    }
}
