﻿using System;
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

    public enum AtmOperations
    {
        Default,
        InputPin,
        InputWithdraw
    }

    public partial class ATM : Form
    {
        private Bank bank;
        private Card cardInserted;
        private Card[] cards;
        private readonly Random rnd;
        private string pin;
        private int operation = (int) AtmOperations.Default;
        // Stores the user's amount selected using any operation in currency
        private string amountText = "";

        public ATM(ref Bank bank)
        {
            InitializeComponent();
            // Sets up default background
            pictureBox.Image = new System.Drawing.Bitmap(Properties.Resources.atm_startup);
            // Allows for transparency of labels
            lblCentre.Parent = pictureBox;
            lblTitle.Parent = pictureBox;
            // Initialises variables
            this.bank = bank;
            rnd = new Random();
            InitCards();
        }

        private void InitCards()
        {
            cards = new Card[3];
            for (var index = 0; index < cards.Length; index++) 
                cards[index] = new Card(rnd);
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
                    Console.WriteLine("Card inserted");
                    operation = (int) AtmOperations.InputPin;
                    pictureBox.Image = new System.Drawing.Bitmap(Properties.Resources.sky);
                    lblCentre.Text = "";
                    lblTitle.Text = "Please enter your pin";
                    lblCentre.Visible = true;
                    lblTitle.Visible = true;

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
                    pictureBox.Image = new System.Drawing.Bitmap(Properties.Resources.atm_startup);
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
            var popup = MessageBox.Show("ATM Simulator \n\nCreated and programmed by:\n\nMax Kelly \nTadas Saltenis \nMax Fyall \n\nThank you", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var popup = MessageBox.Show("PLACEHOLDER, PUT HELPFUL TEXT HERE FOR HOW TO USE THE ATM", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var exit = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (exit == DialogResult.Yes)
                Application.Exit();
        }

        private void keypad_Click(object sender, EventArgs e)
        {
            var keyButton = (Button) sender;
            // Checks if button is a number
            if (int.TryParse(keyButton.Text, out _)) { 
                switch (operation)
                {
                    case (int) AtmOperations.InputPin:
                        pin += keyButton.Text;
                        lblCentre.Text += '*'; 
                        break;
                    case (int) AtmOperations.InputWithdraw:
                        break;
                    default:
                        Console.WriteLine("Error: Keypad Input Invalid Operation as Integer");
                        break;
                }
            }
            else
            {
                switch (keyButton.Text)
                {
                    case "CANCEL":
                        operation = (int) AtmOperations.Default;
                        break;
                    case "CLEAR":
                        amountText = "";
                        break;
                    case "ENTER":
                        processOperation();
                        break;
                    default:
                        Console.WriteLine("Error: Keypad Button not identified");
                        break;
                }
            }

        }

        private void selector_Click(object sender, EventArgs e)
        {
            var selectorButton = (Button) sender;
        }

        private void processOperation()
        {
            switch (operation)
            {
                case (int) AtmOperations.InputPin:
                    CheckPin(amountText);
                    amountText = "";
                    break;
                case (int) AtmOperations.InputWithdraw:
                    var amount = int.Parse(amountText);
                    Withdraw(amount);
                    break;
                case (int) AtmOperations.Default:
                    break;
                default:
                    Console.WriteLine("Error: Invalid Process Operation");
                    break;
            }       
        }

        /* private void pictureBox_Click(object sender, EventArgs e)
        {
            pictureBox.Image = new System.Drawing.Bitmap(Properties.Resources.atm_startup);
            pictureBox.Image = new System.Drawing.Bitmap(Properties.Resources.sky);
        }*/
    }
}