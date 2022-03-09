using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appPlayerConsent
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void btnHold_Click(object sender, EventArgs e)
        {
            EndGame();
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            randomNum = randomiser.Next(0, 52);
            displayCard();
            calculatePlayerTotalValue();
            hitBtnCounter++;

        }

        // Global objects
        static Random randomiser = new Random();

        // Globel variables //
        int playerTotalValue = 0;
        int hitBtnCounter = 1;
        int randomNum;
        int dealerValue;

        // Methods // 

        // Randomly select card and return value
        int RandomCard()
        {

            // variables
            int cardValue = 0;
            
            // display card image per random
             // this is a problem

            // 11 = Ace, 10 = King, Queen, Jack
            if (randomNum >= 48 && randomNum <= 51)
            {
                cardValue = 11;
            }
            else if (randomNum >= 32 && randomNum <= 47)
            {
                // display king, queen or jack
                cardValue = 10;
            }
            else
            {
                switch (randomNum)
                {
                    case 0:
                    case 8:
                    case 16:
                    case 24:
                        cardValue = 2;
                        break;
                    case 1:
                    case 9:
                    case 17:
                    case 25:
                        cardValue = 3;
                        break;
                    case 2:
                    case 10:
                    case 18:
                    case 26:
                        cardValue = 4;
                        break;
                    case 3:
                    case 11:
                    case 19:
                    case 27:
                        cardValue = 5;
                        break;
                    case 4:
                    case 12:
                    case 20:
                    case 28:
                        cardValue = 6;
                        break;
                    case 5:
                    case 13:
                    case 21:
                    case 29:
                        cardValue = 7;
                        break;
                    case 6:
                    case 14:
                    case 22:
                    case 30:
                        cardValue = 8;
                        break;
                    case 7:
                    case 15:
                    case 23:
                    case 31:
                        cardValue = 9;
                        break;
                    default:
                        cardValue = 0;
                        break;
                }
            }
            return cardValue;
        }
        
        // End game and choose winner
        void EndGame()
        {
            dealerValue = DealerValue();
            lblDealerValue.Text = dealerValue.ToString();

            if (dealerValue > 21 && playerTotalValue < 22)
            {
                MessageBox.Show("Dealer bust! Player wins!");
            }
            else if (playerTotalValue > 21 && dealerValue < 22)
            {
                MessageBox.Show("Player bust! Dealer wins!");
            } else
            {
                if (playerTotalValue > dealerValue)
                {
                    MessageBox.Show("Player wins!");
                    // end game
                }
                else if (dealerValue > playerTotalValue)
                {
                    MessageBox.Show("Dealer wins!");
                    // end game
                }
                else
                {
                    MessageBox.Show("Draw!");
                    // end game
                }
            }
            gameRestart();
        }

        // 
        void calculatePlayerTotalValue()
        {
            int playerValue = RandomCard();

            // 
            playerTotalValue = playerTotalValue + playerValue;
            // show total value
            lblPlayerTotalValue.Text = playerTotalValue.ToString();

            // if over 21 player loses
            if (playerTotalValue > 21)
            {
                EndGame();
            }
        }

        void displayCard()
        {
            switch (hitBtnCounter)
            {
                case 1:
                    picDisplayCard.Image = imgLstCards.Images[randomNum];
                    break;
                case 2:
                    picDisplayCard2.Image = imgLstCards.Images[randomNum];
                    break;
                case 3:
                    picDisplayCard3.Image = imgLstCards.Images[randomNum];
                    break;
                case 4:
                    picDisplayCard4.Image = imgLstCards.Images[randomNum];
                    break;
                case 5:
                    picDisplayCard5.Image = imgLstCards.Images[randomNum];
                    break;
            }
        }

        int DealerValue()
        {
            return randomiser.Next(17, 26);
        }

        void gameRestart()
        {
                Application.Restart();
                Environment.Exit(0);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("• Each card is drawn from a full standard pack of 52. Assuming an Ace is worth 11 all the time. “2” is worth 2, “3” is worth 3 and so on until 10. Jack, Queen and King are also worth 10." + Environment.NewLine +
                "• The player draws 2 cards.If the total of the 2 cards is 21, Blackjack is achieved, and the player immediately wins the game." + Environment.NewLine +
                "• Otherwise the player can Hold or continue to Draw up to 3 more cards. If the score exceeds 21 the player is deemed bust and the Dealer wins." + Environment.NewLine +
                "• Once the player holds or draws a 5th Card, the Dealer’s score is shown." + Environment.NewLine +
                "• The nearest hand scoring up to and including 21 is considered the winner. It is also possible to draw.", "Help Facility");
        }
    }
}
