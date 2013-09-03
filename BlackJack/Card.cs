using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Card
    {
        private static Random _r = new System.Random();

        private int valueDigit = _r.Next(13);
        private int colorDigit = _r.Next(4);

        private string ValueName; //The name of the value on the card
        private int ValuePlayed; //The value when the card is played

        private string ColorName;

        

        private string nameColor()
        {
            try
            {
                switch (colorDigit)
                {
                    case 0:
                        ColorName = "Clubs";
                        break;
                    case 1:
                        ColorName = "Spades";
                        break;
                    case 2:
                        ColorName = "Hearts";
                        break;
                    case 3:
                        ColorName = "Diamonds";
                        break;
                }
                return ColorName;
            }

            catch (Exception)
            {
                return "error";
            }
        }


        private string nameValue()
            {
                try 
                { 
                switch(valueDigit)
                {
                    case 0:
                        ValueName = "Ace";
                        ValuePlayed = 11;
                        break;
                    case 1:
                        ValueName = "Two";
                        ValuePlayed = 2;
                        break;
                    case 2:
                        ValueName = "Three";
                        ValuePlayed = 3;
                        break;
                    case 3:
                        ValueName = "Four";
                        ValuePlayed = 4;
                        break;
                    case 4:
                        ValueName = "Five";
                        ValuePlayed = 5;
                        break;
                    case 5:
                        ValueName = "Six";
                        ValuePlayed = 6;
                        break;
                    case 6:
                        ValueName = "Seven";
                        ValuePlayed = 7;
                        break;
                    case 7:
                        ValueName = "Eight";
                        ValuePlayed = 8;
                        break;
                    case 8:
                        ValueName = "Nine";
                        ValuePlayed = 9;
                        break;
                    case 9:
                        ValueName = "Ten";
                        ValuePlayed = 10;
                        break;
                    case 10:
                        ValueName = "Jack";
                        ValuePlayed = 10;
                        break;
                    case 11:
                        ValueName = "Queen";
                        ValuePlayed = 10;
                        break;
                    case 12:
                        ValueName = "King";
                        ValuePlayed = 10;
                        break;
                }
                    return ValueName;
                }
                catch(Exception)
                {return "error";}
            }

        private int pointsValue()
        {
            try
            {
                switch (valueDigit)
                {
                    case 0:
                       
                        ValuePlayed = 11;
                        break;
                    case 1:
                        
                        ValuePlayed = 2;
                        break;
                    case 2:
                        
                        ValuePlayed = 3;
                        break;
                    case 3:
                        
                        ValuePlayed = 4;
                        break;
                    case 4:
                        
                        ValuePlayed = 5;
                        break;
                    case 5:
                        
                        ValuePlayed = 6;
                        break;
                    case 6:
                        
                        ValuePlayed = 7;
                        break;
                    case 7:
                       
                        ValuePlayed = 8;
                        break;
                    case 8:
                        
                        ValuePlayed = 9;
                        break;
                    case 9:
                       
                        ValuePlayed = 10;
                        break;
                    case 10:
                       
                        ValuePlayed = 10;
                        break;
                    case 11:
                        
                        ValuePlayed = 10;
                        break;
                    case 12:
                        
                        ValuePlayed = 10;
                        break;
                }
                return ValuePlayed;
            }
            catch (Exception)
            { return 0; }
        }


        public string Color
        {
            get
            {
                return this.ColorName = nameColor();
            }
        }

        public string Value
        {
            get
            {
                return this.ValueName = nameValue();
            }
        }

        public int ValuePoints
        {
            get
            {
                return this.ValuePlayed = pointsValue();
            }
        }
        


    }

}
