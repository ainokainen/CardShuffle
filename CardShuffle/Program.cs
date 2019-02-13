using System;

namespace CardShuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            DeckOfCards dc = new DeckOfCards();
            dc.FillDeck();
            dc.PrintShuffledDeck();

            
        }
    }
}
