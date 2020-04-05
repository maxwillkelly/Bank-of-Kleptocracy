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
    // Returned by methods to indicate success or failure
    public enum AtmStates
    {
        Success,
        InvalidCardIndex,
        IncorrectPin,
        CardInserted,
        CardNotInitialised,
        CardNotInserted,
        AccountNotFound,
        InsufficientFunds,
        DepositTooLarge,
    }

    // Used by button to determine what the ATM is currently doing
    public enum AtmOperations
    {
        Default,
        InputPin,
        InputOptions,
        InputBalance,
        InputDeposit,
        InputWithdraw
    }

    public partial class ATM : Form
    {

        private Bank bank;
        private Card cardInserted;
        private List<Card> cards;
        private Label[] labels;
        
        // User's inputted pin
        private string pin;
        // User's amount selected using any operation in currency
        private string amount = "";
        // Atm operation we are currently doing
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

            // Shows insert card page on ATM
            displayInsertCard();
            // Initialises variables
            this.bank = bank;
            cards = new List<Card>();
        }

        // Creates cards to use to access a bank account
        public void CreateCard(int accountNumber)
        {
            cards.Add(new Card(accountNumber));
        }

        /*
         * Background functionality - no UI code
         */

        // Inserts a card into the ATM based on its position in the cards list
        private int InsertCard(int cardIndex)
        {
            // Checks for errors
            if (cardIndex >= cards.Count)
                return (int) AtmStates.InvalidCardIndex;

            if (cardInserted != null)
                return (int) AtmStates.CardInserted;

            var card = cards[cardIndex];
            if (card.GetType() != typeof(Card))
                return (int) AtmStates.CardNotInitialised;

            // Stores inserted card
            cardInserted = card;
            return (int) AtmStates.Success;
        }

        // Retrieves an account's balance from the bank
        private int CheckBalance(out int balance)
        {
            operation = (int) AtmOperations.InputBalance;
            // Extracts balance from bank
            balance = bank.balanceCheck(cardInserted.AccountNumber, pin);
            // Interprets balance output
            switch (balance)
            {
                case -1:
                    return (int) AtmStates.AccountNotFound;
                case -2:
                    return (int) AtmStates.IncorrectPin;
            }
            return (int) AtmStates.Success;
        }

        // Checks if a pin is correct
        private int CheckPin(string pin)
        {
            if (cardInserted == null)
                return (int) AtmStates.CardNotInserted;

            this.pin = pin;

            // Extracts the index of the appropriate account in the bank
            var accountIndex = bank.checkPin(cardInserted.AccountNumber, pin);
            // Processes output
            switch (accountIndex)
            {
                case -1:
                    return (int) AtmStates.AccountNotFound;
                case -2:
                    return (int) AtmStates.IncorrectPin;
            }
            return (int) AtmStates.Success;
        }

        // Ejects a card from the ATM
        private int EjectCard()
        {
            if (cardInserted == null)
                return (int) AtmStates.CardNotInserted;

            cardInserted = null;
            pin = "";
            return (int) AtmStates.Success;
        }

        // Withdraws money from an account
        private int Withdraw(int amount)
        {
            if (cardInserted == null)
                return (int) AtmStates.CardNotInserted;

            // Withdraws money from the account
            var withdraw = bank.balanceWithdraw(cardInserted.AccountNumber, pin, amount);
            
            // Processes output
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

        // Deposits money into an account
        private int Deposit(int amount)
        {
            if (cardInserted == null)
                return (int)AtmStates.CardNotInserted;

            // Deposit money into the account
            var withdraw = bank.balanceDeposit(cardInserted.AccountNumber, pin, amount);

            // Processes output
            switch (withdraw)
            {
                case 1:
                    return (int)AtmStates.DepositTooLarge;
                case -1:
                    return (int)AtmStates.AccountNotFound;
                case -2:
                    return (int)AtmStates.IncorrectPin;
            }

            return (int)AtmStates.Success;
        }

        // Not used
        // Prints information stored on the stored cards
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
         * User Interface Button Handlers
         */
         
        // Runs when a user clicks an "Insert a card" button 
        private void insertCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = (Button) sender;
            // Determines which card is attempting to be inserted
            var cardNum = item.Name[10] - '0' - 1;

            // Attempts to insert card and displays an appropriate MessageBox if there are errors
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
                    // Allows the user to input a pin
                    displayInputPin();
                    break;
                default:
                    MessageBox.Show("Generic Error occurred on card insertion");
                    break;
            }
        }

        // Runs when a user clicks the "Eject card" button 
        private void ejectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processEject();
        }

        // About dialog
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ATM Simulator \n\nCreated and programmed by:\n\nMax Kelly \nTadas Saltenis \nMax Fyall \n\nThank you", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Cards help
        private void insertingCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Inserting a Card:\n\nTo insert a card, click one of the 3  'Insert Card X' buttons.\n" +
                "\nPin Numbers: \n\nUpon inserting a card you will be asked to insert a pin number. You can find the pin numbers for all our generated accounts in the bank long form. You can then use the keypad to enter in your pin number. Using the clear button will clear the numbers you entered if you entered a wrong digit in for example" +
                "\n\nEjecting a Card: \n\nIf you want to eject a card, push the CANCEL button on the keypad", "Cards", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ATM Menu help
        private void aTMMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Upon being loaded into the bank menu in the atm you can select 1 of 3 options. Withdraw cash, Deposit or Display balance. Use the Buttons next to these options to select them." ,"ATM Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Withdrawing Money help
        private void withdrawingMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Upon clicking on either withdraw or deposit cash, you will be prompted for how much money you want to withdraw/deposit. Enter the amount of money you want to withdraw/deposit using the keypad.", "Withdrawing/Depositing Money", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Viewing Balance help
        private void viewingBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Upon clicking on display balance, the balance of your bank account will show for 3 seconds then it will disappear", "Viewing Balance", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Exit dialog
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var exit = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (exit == DialogResult.Yes)
                Application.Exit();
        }

        // Runs when the user clicks a number on the keypad e.g. 1, 4, 9
        private void keypad_Click(object sender, EventArgs e)
        {
            var keyButton = (Button) sender;
            // Checks if button is a number
            if (int.TryParse(keyButton.Text, out _))
            {
                // Determines what to do based on what the ATM is doing
                switch (operation)
                {
                    case (int) AtmOperations.InputPin:
                        pin += keyButton.Text;
                        // Hides digits
                        lblCentre.Text += '*';
                        break;
                    case (int) AtmOperations.InputDeposit:
                    case (int) AtmOperations.InputWithdraw:
                        amount += keyButton.Text;
                        // Shows the user what they are typing
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

        // Cancel click handler
        private void cancel_Click(object sender, EventArgs e)
        {
            // Determines what to do based on what the ATM is doing
            switch (operation)
            {
                case (int) AtmOperations.InputBalance:
                    // Displays options menu
                    displayMainMenu();
                    break;
                case (int) AtmOperations.InputPin:
                    pin = "";
                    // Ejects card
                    processEject();
                    break;
                case (int) AtmOperations.InputDeposit:
                case (int) AtmOperations.InputWithdraw:
                    amount = "";
                    // Ejects card
                    processEject();
                    break;
                case (int) AtmOperations.InputOptions:
                    // Ejects card
                    processEject();
                    break;
                case (int) AtmOperations.Default:
                    break;
                default:
                    Console.WriteLine("Error: Invalid Cancel Operation");
                    break;
            }
            // Resets operation
            operation = (int) AtmOperations.Default;
        }

        // Clear click handler
        private void clear_Click(object sender, EventArgs e)
        {
            // Resets centre text
            lblCentre.Text = "";
            // Clears appropriate variable depending on operation
            switch (operation)
            {
                case (int) AtmOperations.InputPin:
                    pin = "";
                    break;
                case (int) AtmOperations.InputDeposit:
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

        // Enter click handler
        private void enter_Click(object sender, EventArgs e)
        {
            // Determines what to do based on what the ATM is doing
            switch (operation)
            {
                case (int) AtmOperations.InputPin:
                    // Validates the entered pin
                    processCheckPin();
                    break;
                case (int) AtmOperations.InputDeposit:
                    processDeposit();
                    break;
                case (int) AtmOperations.InputWithdraw:
                    // Withdraws money
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

        // Selector e.g. Buttons around the edge of the screen click handler
        private void selector_Click(object sender, EventArgs e)
        {
            var selectorButton = (Button) sender;
            // Gets the label variable associated with the selector 
            var label = getLabel(selectorButton);

            // Determines what to do based on what the ATM is doing
            switch (operation)
            {
                case (int) AtmOperations.InputOptions:
                    // Determines action based on label text
                    switch (label.Text)
                    {
                        case "Withdraw Cash":
                            operation = (int) AtmOperations.InputWithdraw;
                            // Allows the user to input an amount
                            displaySpecifyWithdraw();
                            break;
                        case "Display Balance":
                            // Displays balance of the account
                            processBalance();
                            break;
                        case "Deposit":
                            operation = (int) AtmOperations.InputDeposit;
                            // Allows the user to input an amount
                            displaySpecifyDeposit();
                            break;
                        case "Eject Card":
                            processEject();
                            break;
                        default:
                            Console.WriteLine("Operation not identified: " + label.Text);
                            break;
                    }
                    break;
            }
        }

        /*
        * User Interface Processing
        */

        // Attempts to eject card and displays errors if appropriate
        private void processEject() {
            switch (EjectCard())
            {
                case (int) AtmStates.CardNotInserted:
                    MessageBox.Show("No card inserted");
                    break;
                case (int) AtmStates.Success:
                    // Asks the user to take their card and returns to start screen
                    displayEjectCard();
                    break;
                default:
                    MessageBox.Show("Generic Error occurred on card ejection");
                    break;
            }
        }

        // Checks a pin and displays the outcome
        private void processCheckPin()
        {
            // Verfies the pin
            switch (CheckPin(pin))
            {
                case (int) AtmStates.Success:
                    // Displays the main options screen with Display Balance and Withdraw options
                    displayMainMenu();
                    break;
                case (int) AtmStates.AccountNotFound:
                    // Displays account not found screen, ejects the card and returns to the start screen
                    displayAccountNotFound();
                    break;
                case (int) AtmStates.IncorrectPin:
                    // Displays incorrect pin screen, ejects the card and returns to the start screen
                    displayIncorrectPin();
                    break;
                default:
                    break;
            }
        }

        // Gets account balance and displays it
        private void processBalance()
        {
            var returnVal = CheckBalance(out var balance);
            displayBalance(returnVal, balance);
        }

        // Attempts to withdraw money and displays the outcome
        private void processWithdraw()
        {
            var amountInt = int.Parse(amount);
            amount = "";
            // Attempts to withdraw money
            switch (Withdraw(amountInt))
            {
                case (int) AtmStates.Success:
                    // Asks the user to take their cash
                    displayWithdraw();
                    break;
                case (int) AtmStates.InsufficientFunds:
                    displayInsufficientFunds();
                    break;
                case (int) AtmStates.AccountNotFound:
                    // Displays account not found screen, ejects the card and returns to the start screen
                    displayAccountNotFound();
                    break;
                case (int) AtmStates.IncorrectPin:
                    // Displays incorrect pin screen, ejects the card and returns to the start screen
                    displayIncorrectPin();
                    break;
            }
        }

        private void processDeposit()
        {
            var amountInt = int.Parse(amount);
            amount = "";

            // Attempts to withdraw money
            switch (Deposit(amountInt))
            {
                case (int)AtmStates.Success:
                    displayDeposit();
                    break;
                case (int)AtmStates.DepositTooLarge:
                    displayDepositTooLarge();
                    break;
                case (int)AtmStates.AccountNotFound:
                    // Displays account not found screen, ejects the card and returns to the start screen
                    displayAccountNotFound();
                    break;
                case (int)AtmStates.IncorrectPin:
                    // Displays incorrect pin screen, ejects the card and returns to the start screen
                    displayIncorrectPin();
                    break;
            }
        }

        // Returns the matching label matching with an inputted selector
        // Terrible bit of code: tried to do it any other way before giving up
        private Label getLabel(Button selectorButton)
        {
            // Converts selector name to the equivalent label
            var labelName = "lbl" + selectorButton.Name.Substring(8);

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

        /*
        * User Interface Display
        */

        // Hides all labels on screen
        private void displayReset()
        {
            foreach (var label in labels)
            {
                label.Visible = false;
            }
        }

        // Displays start screen
        private void displayInsertCard()
        {
            operation = (int) AtmOperations.Default;
            displayReset();
            pictureBox.Image = new Bitmap(Resources.atm_startup);
        }

        // Asks the user to take their card and returns to start screen
        private async void displayEjectCard() {
            displayReset();
            pictureBox.Image = new Bitmap(Resources.take_card_singular);
            await Task.Delay(1500);
            displayInsertCard();
        }

        // Allows the user to input a pin
        private void displayInputPin()
        {
            operation = (int) AtmOperations.InputPin;
            displayReset();
            pictureBox.Image = new Bitmap(Resources.pinNumber);
            lblCentre.Text = "";
            lblCentre.Visible = true;
        }

        // Displays the main options screen with Display Balance and Withdraw options
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
            lblBottomLeft.Text = "Deposit";
            lblBottomLeft.Visible = true;
            lblBottomRight.Text = "Eject Card";
            lblBottomRight.Visible = true;
        }

        // Allows the user to input an amount
        private void displaySpecifyWithdraw()
        {
            displayReset();
            pictureBox.Image = new Bitmap(Resources.specify_withdraw);
            lblCentre.Text = "£";
            lblCentre.Visible = true;
        }

        // Allows the user to input an amount
        private void displaySpecifyDeposit()
        {
            displayReset();
            pictureBox.Image = new Bitmap(Resources.deposit);
            lblCentre.Text = "£";
            lblCentre.Visible = true;
        }

        // Displays the account balance and returns to the main menu
        private async void displayBalance(int returnVal, int balance)
        {
            operation = (int) AtmOperations.Default;
            displayReset();
            pictureBox.Image = new Bitmap(Resources.sky);
            lblCentre.Text = "£" + balance.ToString("N0");
            lblCentre.Visible = true;
            lblTitle.Text = "You have";
            lblTitle.Visible = true;
            await Task.Delay(3000);
            // Displays the main options screen with Display Balance and Withdraw options
            displayMainMenu();
        }

        // Asks the user to take their cash and returns to the main menu
        private async void displayWithdraw()
        {
            operation = (int) AtmOperations.Default;
            displayReset();
            pictureBox.Image = new Bitmap(Resources.take_cash);
            await Task.Delay(3000);
            // Displays the main options screen with Display Balance and Withdraw options
            displayMainMenu();
        }

        private async void displayDeposit()
        {
            operation = (int) AtmOperations.InputDeposit;
            displayReset();
            pictureBox.Image = new Bitmap(Resources.deposit_complete);
            await Task.Delay(3000);
            // Displays the main options screen with Display Balance and Withdraw options
            displayMainMenu();
        }

        // Displays account not found screen, ejects the card and returns to the start screen
        private async void displayAccountNotFound()
        {
            operation = (int) AtmOperations.Default;
            displayReset();
            pictureBox.Image = new Bitmap(Resources.sky);
            lblCentre.Text = "Account number not found: Contact Support";
            lblCentre.Visible = true;
            await Task.Delay(3000);
            // Ejects the card
            processEject();
        }

        // Displays incorrect pin screen, ejects the card and returns to the start screen
        private async void displayIncorrectPin()
        {
            operation = (int) AtmOperations.Default;
            displayReset();
            pictureBox.Image = new Bitmap(Resources.wrong_pin);
            await Task.Delay(3000);
            // Ejects the card
            processEject();
        }

        private async void displayInsufficientFunds()
        {
            operation = (int) AtmOperations.Default;
            displayReset();
            pictureBox.Image = new Bitmap(Resources.insufficient);
            await Task.Delay(3000);
            // Displays the main options screen with Display Balance and Withdraw options
            displayMainMenu();
        }


        private async void displayDepositTooLarge()
        {
            operation = (int) AtmOperations.Default;
            displayReset();
            pictureBox.Image = new Bitmap(Resources.too_large);
            await Task.Delay(3000);
            // Displays the main options screen with Display Balance and Withdraw options
            displayMainMenu();
        }
    }
}