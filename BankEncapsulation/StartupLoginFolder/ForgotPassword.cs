﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation.StartupLogin
{
    internal class ForgotPassword
    {
        public static void GoToForgotPassword(BankAccount.BankAccount account, CreditCard.CreditCard card, Loans.Loan loan)
        {
            Console.Clear();
            Console.WriteLine("Forgot Password Screen\n\n");
            Console.WriteLine("Please contact the technical support team at 800-123-4567 to reset your password.\n\n");
            Console.WriteLine("Press any key to return to the Start-Up screen.\n\n");
            Console.ReadKey();
            StartUpScreen.GoToStartUpScreen(account, card, loan);
        }
    }
}
