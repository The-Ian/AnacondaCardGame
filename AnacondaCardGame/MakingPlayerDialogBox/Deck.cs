using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingPlayerDialogBox
{
    class Deck
    {
        private Card[] cards;

        public Deck()
        {
            cards = new Card[52];
            int check = 0;

            for (int suitVal = 1; suitVal < 5; suitVal++)
            {
                for (int rankVal = 1; rankVal < 14; rankVal++)
                {
                    if (suitVal == 1)
                    {
                        cards[check++] = new Card(rankVal, Card.Suit.Clubs);
                    }
                    else if (suitVal == 2)
                    {
                        cards[check++] = new Card(rankVal, Card.Suit.Diamonds);
                    }
                    else if (suitVal == 3)
                    {
                        cards[check++] = new Card(rankVal, Card.Suit.Hearts);
                    }
                    else if (suitVal == 4)
                    {
                        cards[check++] = new Card(rankVal, Card.Suit.Spades);
                    }
                }
            }
        }

            static Random r = new Random();

        static public void Shuffle(int[] deck)
        {

            for (int n = deck.Length - 1; n > 0; --n)
            {
                int k = r.Next(n + 1);
                int temp = deck[n];
                deck[n] = deck[k];
                deck[k] = temp;
            }
        }
    }
}
