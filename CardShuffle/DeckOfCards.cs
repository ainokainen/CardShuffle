using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardShuffle
{
    public class DeckOfCards
    {
        public List<Card> Cards = new List<Card>();
        Random random = new Random();
        public void FillDeck()
        {
            //loop through cards
            for (int i = 0; i<52; i++)
            {
                Card.Suites suite = (Card.Suites)(Math.Floor((decimal)i / 13));
                int addTwoToValue = i % 13 + 2;//Add two to value to reach the index of Aces(14)
                Cards.Add(new Card(addTwoToValue, suite));
            }
        }
        public void PrintShuffledDeck()
        {
            //Take instance of cards and order them randomly and print out the deck of cards
            foreach(Card card in this.Cards.OrderBy(x => random.Next()).ToArray())
            {
                Console.Write(card.Name+ ", ");
            }
        }
        

    }


    
}
