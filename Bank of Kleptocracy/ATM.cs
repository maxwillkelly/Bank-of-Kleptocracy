using System;
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
        CardInserted,
        CardNotInitialised,
        CardNotInserted,
        AccountNotFound
    }

    public partial class ATM : Form
    {
        private const string branchName = "Bank of Kleptocracy";
        private Account activeAccount;

        private Bank bank;
        private Card cardInserted;
        private Card[] cards;
        private readonly Random rnd;

        public ATM()
        {
            InitializeComponent();
            rnd = new Random();
            InitCards();
        }

        private void InitCards()
        {
            cards = new Card[3];
            for (var index = 0; index < cards.Length; index++) cards[index] = new Card(rnd);
        }

        // Main functionality
        public int InsertCard(int cardIndex)
        {
            if (cardIndex >= cards.Length)
                return (int) AtmStates.InvalidCardIndex;
            if (cardInserted != null)
                return (int) AtmStates.CardInserted;

            var card = cards[cardIndex];
            if (card.GetType() != typeof(Card))
                return (int) AtmStates.CardNotInitialised;

            var account = FindAccount(card.AccountNumber, card.BankNumber);
            if (account == null)
                return (int) AtmStates.AccountNotFound;

            activeAccount = account;
            cardInserted = card;
            return (int) AtmStates.Success;
        }

        public int CheckBalance()
        {
            if (activeAccount == null)
                return (int) AtmStates.NoActiveAccount;
            return activeAccount.Balance;
        }

        public int CheckPin(int pin)
        {
            if (activeAccount == null)
                return (int) AtmStates.NoActiveAccount;
            if (activeAccount.CheckPin(pin))
                return (int) AtmStates.Success;
            return (int) AtmStates.IncorrectPin;
        }

        public int EjectCard()
        {
            if (cardInserted == null)
                return (int) AtmStates.CardNotInserted;
            cardInserted = null;
            return (int) AtmStates.Success;
        }

        public int Withdraw(int amount)
        {
            if (activeAccount == null)
                return (int) AtmStates.NoActiveAccount;
            return (int) AtmStates.Success;
        }

        private Account FindAccount(int accountNumber, int bankNumber)
        {
            return bank.BankNumber == bankNumber ? bank.GetAccount(accountNumber) : null;
        }

        private void PrintCards()
        {
            for (var cardIndex = 0; cardIndex < cards.Length; cardIndex++)
            {
                var card = cards[cardIndex];
                Console.Write("Card Index:" + cardIndex + "\t");
                card.Print();
                Console.WriteLine();
            }
        }

        // User Interface
        private void insertCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem) sender;
            // Determines which card is being inserted
            var cardNum = item.Name[10] - '0' - 1;
            switch (InsertCard(cardNum))
            {
                case (int) AtmStates.InvalidCardIndex:
                    MessageBox.Show("Invalid Card Index: " + cardNum);
                    break;
                case (int) AtmStates.CardInserted:
                    MessageBox.Show("You can't insert multiple cards, eject the current card before proceeding");
                    break;
                case (int) AtmStates.CardNotInitialised:
                    MessageBox.Show("Card Initalisation Error");
                    break;
                case (int) AtmStates.AccountNotFound:
                    MessageBox.Show("Account not found");
                    break;
                case (int) AtmStates.Success:
                    // TODO: Display Account options
                    Console.WriteLine("Card inserted");
                    break;
                default:
                    MessageBox.Show("Generic Error occurred on card insertion");
                    break;
            }
        }

        private void ejectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (EjectCard())
            {
                case (int) AtmStates.CardNotInserted:
                    MessageBox.Show("No card inserted");
                    break;
                case (int) AtmStates.Success:
                    // TODO: Return to insert card screen
                    Console.WriteLine("Card ejected");
                    break;
                default:
                    MessageBox.Show("Generic Error occurred on card ejection");
                    break;
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Help Dialog
            Console.WriteLine("Display Help");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: About Dialog
            Console.WriteLine("Display About");
        }
    }
}