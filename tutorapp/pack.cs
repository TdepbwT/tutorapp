using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorapp
{
    public class pack
    {
        private List<Card> cards = new List<Card>(); // creating a list of cards
        private Random random = new Random(); // creating a random variable

        public pack(int numberOfCards)
        {
            // create number cards, values 1-10
            for (int i = 1; i <= 10; i++) 
            {
                for (int j = 0; j < numberOfCards / 20; j++) // creating a loop to add cards, divide by 20 to get 2 of each 
                {
                    cards.Add(new Card(i));
                }
            }

            // create operator cards for +, -, *, /
            string[] operators = { "+", "-", "*", "/" }; // creating an array of operators
            foreach (string op in operators)
            {
                for (int i = 0; i < numberOfCards / 10; i++) // creating a loop to add cards, divide by 10 to get 1 of each
                {
                    cards.Add(new Card(op));
                }
            }
        }

        public void Shuffle() // shuffle cards using fisher-yates algorithm
        {
            for (int i = 0; i < cards.Count; i++) // creating a loop to shuffle the cards
            {
                int j = random.Next(cards.Count); // creating a random variable
                Card temp = cards[i]; // creating a temporary card
                cards[i] = cards[j]; // swapping the cards
                cards[j] = temp; // swapping the cards
            }
        }

        public List<Card> Deal() // deal cards
        {
            List<Card> hand = new List<Card>(); // creating a list of cards

            // deal 2 number cards
            for (int i = 0; i < 2; i++) // creating a loop to deal cards
            {
                if (cards.Count == 0)
                {
                    break;
                }
                Card card = cards[0]; // creating a card
                cards.RemoveAt(0); // removing the card from the pack
                if (card.Type == Card.CardType.Number) // checking if the card is a number card
                {
                    hand.Add(card); // adding the card to the hand
                }
                else
                {
                    cards.Add(card); // adding the card back to the pack
                    i--; // try again to get a number card
                }
            }

            // deal 1 operator card
            if (cards.Count > 0)
            {
                Card card = cards[0];
                cards.RemoveAt(0);
                if (card.Type == Card.CardType.Operator)
                {
                    hand.Add(card);
                }
                else
                {
                    cards.Add(card); // put the number card back in the deck
                }
            }
            
            return hand;
        }
    }
}
