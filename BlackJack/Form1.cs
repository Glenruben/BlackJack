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
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Card newCard = new Card();
            result.Text = "Drawing Card!";
            card.Text += newCard.Value + " of " + newCard.Color + ". The value of this card is: " + newCard.ValuePoints + "\n" ;      
            
            //TODO: Add multiple cards, sum feature, checker to see if player is bust.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void stand_Click(object sender, EventArgs e)
        {
            result.Text += " Standing ";
            //TODO: Add total checker to see if player is bust
        }


        private void result_Click(object sender, EventArgs e)
        {

        }


    }
}
