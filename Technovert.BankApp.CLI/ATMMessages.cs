﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technovert.BankApp.CLI
{
    public static class ATMMessages
    {
        public static void DisplayOptionsMsg()
        {
            Console.WriteLine("Press 1. for Creating Account");
            Console.WriteLine("Press 2. for Deposit");
            Console.WriteLine("Press 3. for Withdrawal");
            Console.WriteLine("Press 4. for Transfer Money");
            Console.WriteLine("Press 5. for Show Transactions");
            Console.WriteLine("Press 6. to Exit ATM Application");
        }
        public static void AccountCreationMsg()
        {
            Console.WriteLine("-----Account Creation-----");
            Console.WriteLine("Enter your Name and Initial Deposit");
        }
        public static void AccountDetailsProvidingMsg()
        {
            Console.WriteLine("Enter your account details");
        }
        public static void RecieverAccountDetailsProvidingMsg()
        {
            Console.WriteLine("Enter the Account Details of Reciever");
        }
        public static void DepositAmtMsg()
        {
            Console.WriteLine("Enter amount to be deposited");
        }
        public static void WithdrawAmtMsg()
        {
            Console.WriteLine("Enter amount to be withdrawn");
        }
        public static void InsufficientBalanceMsg()
        {
            Console.WriteLine("You have insufficient balance. Please deposit some amount first");
        }
        public static void TransferFailedMsg()
        {
            Console.WriteLine("Transfer failed due to insufficient balance");
        }
        public static void ExceptionMsg()
        {
            Console.WriteLine("You have entered some of the details incorrectly. Please check back and proceed");
        }

    }
}