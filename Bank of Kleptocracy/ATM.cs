using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_of_Kleptocracy.Properties;

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
        AccountNotFound,
        InsufficientFunds
    }

    public enum AtmOperations
    {
        Default,
        InputPin,
        InputOptions,
        InputBalance,
        InputWithdraw
    }

    public partial class ATM : Form
    {
        private Bank bank;
        private Card cardInserted;
        private List<Card> cards;
        private Label[] labels;
        
        // Stores the user's inputted pin
        private string pin;
        // Stores the user's amount selected using any operation in currency
        private string amount = "";
        // Stores the Atm operation we are currently using
        private int operation = (int) AtmOperations.Default;
        

        public ATM(ref Bank bank)
        {
            InitializeComponent();
            
            // Allows for transparency of labels
            labels = new[] {lblCentre, lblTitle, lblTopLeft, lblMiddleLeft, lblBottomLeft, lblTopRight, lblMiddleRight, lblBottomRight};
            foreach (var lbl in labels)
            {
                lbl.Parent = pictureBox;
            }
            displayInsertCard();
            // Initialises variables
            this.bank = bank;
            cards = new List<Card>();
        }

        public void CreateCard(int accountNumber)
        {
            cards.Add(new Card(accountNumber));
        }

        /*
         * Background functionality
         */
        public int InsertCard(int cardIndex)
        {
            if (cardIndex >= cards.Count)
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

        public int CheckBalance(out int balance)
        {
            balance = bank.balanceCheck(cardInserted.AccountNumber, pin);
            switch (balance)
            {
                case -1:
                    return (int)AtmStates.AccountNotFound;
                case -2:
                    return (int)AtmStates.IncorrectPin;
            }
            return (int) AtmStates.Success;
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
            pin = "";
            return (int) AtmStates.Success;
        }

        public int Withdraw(int amount)
        {
            if (cardInserted == null)
                return (int) AtmStates.CardNotInserted;

            var withdraw = bank.balanceWithdraw(cardInserted.AccountNumber, pin, amount);
            
            switch (withdraw)
            {
                case 1:
                    return (int) AtmStates.InsufficientFunds;
                case -1:
                    return (int) AtmStates.AccountNotFound;
                case -2:
                    return (int) AtmStates.IncorrectPin;
            }

            return (int) AtmStates.Success;
        }

        private void PrintCards()
        {
            for (var cardIndex = 0; cardIndex < cards.Count; cardIndex++)
            {
                var card = cards[cardIndex];
                Console.Write("Card Index:" + cardIndex + "\t");
                card.Print();
                Console.WriteLine();
            }
        }

        /*
         * User Interface
         */
        private void insertCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = (Button) sender;
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
                    displayInputPin();
                    break;
                default:
                    MessageBox.Show("Generic Error occurred on card insertion");
                    break;
            }
        }

        private async void ejectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (EjectCard())
            {
                case (int) AtmStates.CardNotInserted:
                    MessageBox.Show("No card inserted");
                    break;
                case (int) AtmStates.Success:
                    Console.WriteLine("Card ejected");
                    displayReset();
                    pictureBox.Image = new Bitmap(Resources.take_card_singular);
                    await Task.Delay(1500);
                    displayInsertCard();
                    break;
                default:
                    MessageBox.Show("Generic Error occurred on card ejection");
                    break;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var popup = MessageBox.Show("ATM Simulator \n\nCreated and programmed by:\n\nMax Kelly \nTadas Saltenis \nMax Fyall \n\nThank you", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void insertingCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var popup = MessageBox.Show("Inserting a Card:\n\nTo insert a card, click one of the 3  'Insert Card X' buttons.\n" +
                "\nPin Numbers: \n\nUpon inserting a card you will be asked to insert a pin number. You can find the pin numbers for all our generated accounts in the bank computer form. You can then use the keypad to enter in your pin number. Using the clear button will clear the numbers you entered if you entered a wrong digit in for example" +
                "\n\nEjecting a Card: \n\nIf you want to eject a card, push the CANCEL button on the keypad", "Cards", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aTMMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var popup = MessageBox.Show("Upon being loaded into the bank menu in the atm you can select 1 of 3 options. Withdraw cash, Deposit or Display balance. Use the Buttons next to these options to select them." ,"ATM Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void withdrawingMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var popup = MessageBox.Show("Upon clicking on either withdraw or deposit cash, you will be prompted for how much money you want to withdraw/deposit. Enter the amount of money you want to withdraw/deposit using the keypad.", "Withdrawing/Depositing Money", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void viewingBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var popup = MessageBox.Show("Upon clicking on display balance, the balance of your bank account will show for 3 seconds then it will disappear", "Viewing Balance", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (int.TryParse(keyButton.Text, out _))
            {
                switch (operation)
                {
                    case (int) AtmOperations.InputPin:
                        pin += keyButton.Text;
                        lblCentre.Text += '*';
                        break;
                    case (int) AtmOperations.InputWithdraw:
                        amount += keyButton.Text;
                        lblCentre.Text += keyButton.Text;
                        break;
                    default:
                        Console.WriteLine("Error: Keypad Input Invalid Operation as Integer");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error: Keypad Button not identified");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case (int) AtmOperations.InputBalance:
                    displayMainMenu();
                    break;
                case (int) AtmOperations.InputPin:
                    pin = "";
                    ejectToolStripMenuItem_Click(new object(), new EventArgs());
                    break;
                case (int) AtmOperations.InputWithdraw:
                    amount = "";
                    ejectToolStripMenuItem_Click(new object(), new EventArgs());
                    break;
                case (int)AtmOperations.InputOptions:
                    ejectToolStripMenuItem_Click(new object(), new EventArgs());
                    break;
                case (int) AtmOperations.Default:
                    break;
                default:
                    Console.WriteLine("Error: Invalid Cancel Operation");
                    break;
            }

            operation = (int) AtmOperations.Default;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            lblCentre.Text = "";
            switch (operation)
            {
                case (int) AtmOperations.InputPin:
                    pin = "";
                    break;
                case (int) AtmOperations.InputWithdraw:
                    amount = "";
                    break;
                case (int) AtmOperations.Default:
                    break;
                default:
                    Console.WriteLine("Error: Invalid Clear Operation");
                    break;
            }
        }

        private void enter_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case (int) AtmOperations.InputPin:
                    processCheckPin();
                    break;
                case (int) AtmOperations.InputWithdraw:
                    processWithdraw();
                    break;
                case (int) AtmOperations.Default:
                    Console.WriteLine("Default Operation");
                    break;
                default:
                    Console.WriteLine("Error: Invalid Enter Operation");
                    break;
            }
        }

        private void selector_Click(object sender, EventArgs e)
        {
            var selectorButton = (Button) sender;
            var label = getLabel(selectorButton);

            switch (operation)
            {
                case (int) AtmOperations.InputOptions:
                    switch (label.Text)
                    {
                        case "Withdraw Cash":
                            Console.WriteLine("Withdraw Cash");
                            operation = (int) AtmOperations.InputWithdraw;
                            displayInputAmount();
                            break;
                        case "Display Balance":
                            processBalance();
                            break;
                        default:
                            Console.WriteLine("Operation not identified: " + label.Text);
                            break;
                    }

                    break;
            }
        }

        private void processCheckPin()
        {
            switch (CheckPin(pin))
            {
                case (int)AtmStates.Success:
                    displayMainMenu();
                    break;
                case (int)AtmStates.AccountNotFound:
                    Console.WriteLine("Account Not Found");
                    displayAccountNotFound();
                    break;
                case (int)AtmStates.IncorrectPin:
                    Console.WriteLine("Incorrect Pin");
                    displayIncorrectPin();
                    break;
                default:
                    break;
            }
        }

        private void processWithdraw()
        {
            var amountInt = int.Parse(amount);
            var returnVal = Withdraw(amountInt);
            amount = "";
            switch (returnVal)
            {
                case (int) AtmStates.Success:
                    displayWithdraw();
                    break;
                case (int) AtmStates.InsufficientFunds:
                    displayInsufficientFunds();
                    break;
                case (int) AtmStates.AccountNotFound:
                    displayAccountNotFound();
                    break;
                case (int) AtmStates.IncorrectPin:
                    displayIncorrectPin();
                    break;
            }
        }

        private void processBalance()
        {
            Console.WriteLine("Display Balance");
            operation = (int) AtmOperations.InputBalance;
            var returnVal = CheckBalance(out var balance);
            displayBalance(returnVal, balance);
        }

        // Returns the matching label matching with an inputted selector
        private Label getLabel(Button selectorButton)
        {
            var labelName = "lbl" + selectorButton.Name.Substring(8);
            // return (Label) GetType().GetField(labelName).GetValue(this);

            switch (labelName)
            {
                case "lblTopLeft":
                    return lblTopLeft;
                case "lblMiddleLeft":
                    return lblMiddleLeft;
                case "lblBottomLeft":
                    return lblBottomLeft;
                case "lblTopRight":
                    return lblTopRight;
                case "lblMiddleRight":
                    return lblMiddleRight;
                case "lblBottomRight":
                    return lblBottomRight;
                default:
                    Console.WriteLine("Label " + labelName + " not recognised Centre returned");
                    return lblCentre;
            }
        }

        private void displayReset()
        {
            foreach (var label in labels)
            {
                label.Visible = false;
            }
        }

        private void displayInsertCard()
        {
            operation = (int) AtmOperations.Default;
            displayReset();
            pictureBox.Image = new Bitmap(Resources.atm_startup);
        }

        private void displayInputPin()
        {
            operation = (int)AtmOperations.InputPin;
            displayReset();
            pictureBox.Image = new Bitmap(Resources.pinNumber);
            lblCentre.Text = "";
            lblCentre.Visible = true;
            //lblTitle.Text = "Please enter your pin";
            //lblTitle.Visible = true;
        }

        private void displayMainMenu()
        {
            operation = (int) AtmOperations.InputOptions;
            displayReset();
            pictureBox.Image = new Bitmap(Resources.menu);
            lblTitle.Text = "Select an operation";
            lblTitle.Visible = true;
            lblMiddleLeft.Text = "Withdraw Cash";
            lblMiddleLeft.Visible = true;
            lblMiddleRight.Text = "Display Balance";
            lblMiddleRight.Visible = true;
        }
        private void displayInputAmount()
        {
            displayReset();
            pictureBox.Image = new Bitmap(Resources.specify_withdraw);
            lblCentre.Text = "£";
            lblCentre.Visible = true;
            //lblTitle.Text = "Enter you Amount";
            //lblTitle.Visible = true;
        }

        private async void displayBalance(int returnVal, int balance)
        {
            operation = (int)AtmOperations.Default;
            displayReset();
            pictureBox.Image = new Bitmap(Resources.sky);
            lblCentre.Text = "£" + balance.ToString("N0");
            lblCentre.Visible = true;
            lblTitle.Text = "You have";
            lblTitle.Visible = true;
            await Task.Delay(3000);
            displayMainMenu();
        }

        private async void displayWithdraw()
        {
            operation = (int)AtmOperations.Default;
            displayReset();
            pictureBox.Image = new Bitmap(Resources.take_card);
            Console.WriteLine("Card Ejected");
            await Task.Delay(1500);
            //lblCentre.Text = "Take money";
            pictureBox.Image = new Bitmap(Resources.take_cash);
            await Task.Delay(3000);
            displayMainMenu();
        }

        private async void displayAccountNotFound()
        {
            operation = (int)AtmOperations.Default;
            displayReset();
            pictureBox.Image = new Bitmap(Resources.sky);
            lblCentre.Text = "Account number not found: Contact Support";
            lblCentre.Visible = true;
            await Task.Delay(3000);
            ejectToolStripMenuItem_Click(new object(), new EventArgs());
        }

        private async void displayIncorrectPin()
        {
            operation = (int)AtmOperations.Default;
            displayReset();
            pictureBox.Image = new Bitmap(Resources.wrong_pin);
            await Task.Delay(3000);
            ejectToolStripMenuItem_Click(new object(), new EventArgs());
        }

        private async void displayInsufficientFunds()
        {
            operation = (int)AtmOperations.Default;
            displayReset();
            pictureBox.Image = new Bitmap(Resources.sky);
            await Task.Delay(3000);
            displayMainMenu();
        }
    }
}