using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorapp
{
   
       public class Card // initialising card class
    {
        public enum CardType // there are two types of cards, number and operator
        {
            Number,
            Operator
        }
        public CardType Type { get; set; } // setting the type of card
        public int Value { get; set; } // setting the value of the card
        public string Operator { get; set; } // setting the operator of the card

        public Card(int value) // setting the value of the card
        {
            Type = CardType.Number;
            Value = value;
        }

        public Card(string @operator) // setting operator of the card; @ is used to allow the use of keywords as variables
        {
            Type = CardType.Operator;
            Operator = @operator;
        }

        public override string ToString() // converting the card to a string
        {
            if (Type == CardType.Number)
            {
                return Value.ToString();
            }
            else
            {
                return Operator;
            }
        }

    }
    
}