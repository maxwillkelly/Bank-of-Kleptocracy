﻿using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_of_Kleptocracy
{
    class Card
    {
        public int AccountNumber { get; }

        public Card(Random rnd)
        {
            AccountNumber = rnd.Next(111,9999);
        }

        public Card(int accountNumber)
        {
            AccountNumber = accountNumber;
        }

        public void Print()
        {
            Console.Write("Account Number: " + AccountNumber);
        }
    }
}
