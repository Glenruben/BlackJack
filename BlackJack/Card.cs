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

        private string ValueName;

        private string nameValue()
            {
                try 
                { 
                switch(valueDigit)
                {
                    case 0:
                        ValueName = "Ace";
                        break;
                    case 1:
                        ValueName = "Two";
                        break;
                    case 2:
                        ValueName = "Three";
                        break;
                    case 3:
                        ValueName = "Four";
                        break;
                    case 4:
                        ValueName = "Five";
                        break;
                    case 5:
                        ValueName = "Six";
                        break;
                    case 6:
                        ValueName = "Seven";
                        break;
                    case 7:
                        ValueName = "Eight";
                        break;
                    case 8:
                        ValueName = "Nine";
                        break;
                    case 9:
                        ValueName = "Ten";
                        break;
                    case 10:
                        ValueName = "Jack";
                        break;
                    case 11:
                        ValueName = "Queen";
                        break;
                    case 12:
                        ValueName = "King";
                        break;
                }
                    return ValueName;
                }
                catch(Exception)
                {return "error";}
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



    }

}
