using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_of_Kleptocracy
{
    public enum AtmStates
    {
        Success,
        NoActiveAccount,
        NoCardInserted,
        InvalidCardIndex,
        IncorrectPin,
        CardNotInitialised,
        CardNotInserted,
        AccountNotFound
    }

    public partial class ATM : Form
    {
        const string branchName = "Bank of Kleptocracy";

        private Bank[] banks;
        private Card[] cards;
        private Account activeAccount;
        private Card cardInserted;
        private Random rnd;

        public ATM()
        {
            InitializeComponent();
            rnd = new Random();
            InitBanks();
            InitCards();
        }
        private void InitBanks()
        {
            banks = new Bank[10];
        }

        private void InitCards()
        {
            cards = new Card[10];
            for (var index = 0; index < cards.Length; index++)
            {
                cards[index] = new Card(rnd);
            }
        }

        public int InsertCard(int cardIndex)
        {
            if (cardIndex >= cards.Length)
                return (int)AtmStates.InvalidCardIndex;

            var card = cards[cardIndex];
            if (card.GetType() != typeof(Card))
                return (int)AtmStates.CardNotInitialised;

            var account = FindAccount(card.AccountNumber, card.BankNumber);
            if (account == null)
                return (int)AtmStates.AccountNotFound;

            activeAccount = account;
            cardInserted = card;
            return (int)AtmStates.Success;
        }

        public int CheckBalance()
        {
            if (activeAccount == null)
                return (int)AtmStates.NoActiveAccount;
            return activeAccount.Balance;
        }

        public int CheckPin(int pin)
        {
            if (activeAccount == null)
                return (int)AtmStates.NoActiveAccount;
            if (activeAccount.CheckPin(pin))
                return (int)AtmStates.Success;
            return (int)AtmStates.IncorrectPin;

        }

        public int EjectCard()
        {
            if (cardInserted == null)
                return (int)AtmStates.CardNotInserted;
            cardInserted = null;
            return (int)AtmStates.Success;
        }

        public int Withdraw(int amount)
        {
            if (activeAccount == null)
                return (int)AtmStates.NoActiveAccount;
            return (int)AtmStates.Success;
        }

        private Account FindAccount(int accountNumber, int bankNumber)
        {
            foreach (var bank in banks)
            {
                if (bank.BankNumber == bankNumber)
                {
                    return bank.GetAccount(accountNumber);
                }
            }

            return null;
        }

        private void PrintCards()
        {
            for (int cardIndex = 0; cardIndex < cards.Length; cardIndex++)
            {
                var card = cards[cardIndex];
                Console.Write("Card Index:" + cardIndex + "\t");
                card.Print();
                Console.WriteLine();
            }
        }

        private void ATM_Load(object sender, EventArgs e)
        {

        }

        private void testBtn1_Click(object sender, EventArgs e)
        {
            PrintCards();
        }
    }
}
