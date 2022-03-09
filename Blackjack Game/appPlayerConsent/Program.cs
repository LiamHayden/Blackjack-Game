using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appPlayerConsent
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

//•	The player draws 2 cards. If the total of the 2 cards is 21, Blackjack is achieved, and the player immediately wins the game.
//1.	Start game (player given two cards)
//2.Check what total?
//.	Draw card function (Hit)
//4.Hold function
//5.If hold or 5 cards drawn then random gen dealers number
//6.	Display dealers number
//7.	Compare player and dealers numbers, largest noty over 21 wins.
//8.	IF numbers are equal then it is a draw.
//•	Otherwise the player can Hold or continue to Draw up to 3 more cards. If the score exceeds 21 the player is deemed bust and the Dealer wins.

//•	Once the player holds or draws a 5th Card, the Dealer’s score is randomly generated and displayed.  Possible Dealer values are in the range 17-25.

//•	The nearest hand scoring up to and including 21 is considered the winner. It is also possible to draw. 

