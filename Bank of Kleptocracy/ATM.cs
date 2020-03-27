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

        public ATM()
        {
            InitializeComponent();
            InitBanks();
            InitCards();
        }
        public void InitBanks()
        {
            banks = new Bank[10];
        }

        public void InitCards()
        {
            cards = new Card[10];
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

        public int CheckBalance()
        {
            if (activeAccount == null)
                return (int)AtmStates.NoActiveAccount;
            return activeAccount.balance;
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
    }
}
