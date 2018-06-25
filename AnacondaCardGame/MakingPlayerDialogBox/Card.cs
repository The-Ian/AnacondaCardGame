using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingPlayerDialogBox
{
    class Card
    {
        public int Value { get; private set; }
        public enum Suit
        {
            Clubs = 1,
            Diamonds = 2,
            Hearts = 3,
            Spades = 4
        }

        public Suit SuitType { get; private set; }


        public Card(int value, Suit suit)
        {
            SuitType = suit;
            Value = value;
        }

        public override string ToString()
        {
            string output = "";
            if (Value > 10)
            {
                switch (Value)
                {
                    case 11:
                        output += "Jack";
                        break;
                    case 12:
                        output += "Queen";
                        break;
                    case 13:
                        output += "King";
                        break;
                    case 14:
                        output += "Ace";
                        break;
                }
            }
            else
            {
                output += Value;
            }
            output += " of " + System.Enum.GetName(typeof(Suit), SuitType);
            return output;
        }

    }
}
