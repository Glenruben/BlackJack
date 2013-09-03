using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class BlackJackCat : Form
    {
        public BlackJackCat()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Card newCard = new Card();
            infoLabel.Text = "Drawing Card!";
            cardLabel.Text += newCard.Value + " of " + newCard.Color + ". The value of this card is: " + newCard.ValuePoints + "\n" ; 

            int _p = int.Parse(pointCount.Text) + newCard.ValuePoints;
                        
            pointCount.Text = _p.ToString();

            if (_p == 21)
            { 
            bustLabel.Text = "BLACKJACXX whoa that's awesome";
            deal.Enabled = false;
            }

            if (_p > 21)
            {
            deal.Enabled = false;
            bustLabel.Text = "YOU'RE BUST BUDDY!";
            }
      


            
            //TODO: Add multiple cards, sum feature, checker to see if player is bust.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void result_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            cardLabel.Text = "";
            pointCount.Text = "0";
            bustLabel.Text = "";
            deal.Enabled = true;
            infoLabel.Text = "Press DEAL for new card";
        }


    }
}
