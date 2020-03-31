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
        private Bank bank;
        private Card cardInserted;
        private Card[] cards;
        private readonly Random rnd;
        private string pin;

        public ATM(ref Bank bank)
        {
            InitializeComponent();
            this.bank = bank;
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

            /*var account = FindAccount(card.AccountNumber, card.BankNumber);
            if (account == null)
                return (int) AtmStates.AccountNotFound;

            activeAccount = account;*/
            cardInserted = card;
            return (int) AtmStates.Success;
        }

        public int CheckBalance()
        {
            var balance = bank.balanceCheck(cardInserted.AccountNumber, pin);
            switch (balance)
            {
                case -1:
                    return (int)AtmStates.AccountNotFound;
                case -2:
                    return (int)AtmStates.IncorrectPin;
            }
            return balance;
        }

        public int CheckPin(string pin)
        {
            if (cardInserted == null)
                return (int) AtmStates.CardNotInserted;
            this.pin = pin;
            var accountIndex = bank.checkPin(cardInserted.AccountNumber, pin);
            switch (accountIndex)
            {
                case -1:
                    return (int) AtmStates.AccountNotFound;
                case -2:
                    return (int) AtmStates.IncorrectPin;
            }
            return (int) AtmStates.Success;
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
            if (cardInserted == null)
                return (int) AtmStates.CardNotInserted;
            var withdraw = bank.balanceWithdraw(cardInserted.AccountNumber, pin, amount);
            switch (withdraw)
            {
                case -1:
                    return (int) AtmStates.AccountNotFound;
                case -2:
                    return (int) AtmStates.IncorrectPin;
            }
            return (int) AtmStates.Success;
        }

        /*private Account FindAccount(int accountNumber, int bankNumber)
        {
            if (bank.BankNumber == bankNumber)
                return bank.GetAccount(accountNumber);
            return null;
        }*/

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
                    // TODO: Check pin
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

        /*private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Help Dialog
            Console.WriteLine("Display Help");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: About Dialog
            Console.WriteLine("Display About");
        }*/

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult popup;
            popup = MessageBox.Show("ATM Simulator \n\nCreated and programmed by:\n\nMax Kelly \nTadas Saltenis \nMax Fyall \n\nThank you", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult popup;
            popup = MessageBox.Show("PLACEHOLDER, PUT HELPFUL TEXT HERE FOR HOW TO USE THE ATM", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exit;
            exit = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}