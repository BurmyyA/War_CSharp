using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War_Burmeister
{
    /// <summary>
    /// makes the whole deck and then allows for cards to be used and dicarded afterwards. 
    /// </summary>
    class Deck
    {
        private List<Card> cards;
        /// <summary>
        /// Contructs deck of cards. 
        /// </summary>
        public Deck()
        {
            cards = new List<Card>();
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    Card c = new Card((Suit)i, (Face)j);
                    cards.Add(c);
                }
            }
        }
        /// <summary>
        /// makes deck and puts them in list.
        /// </summary>
        /// <param name="cards">the cards being used. </param>
        public Deck(List<Card> cards)
        {
            this.cards = cards;
        }
        /// <summary>
        /// Gets random card and removes it from the deck after its used. 
        /// </summary>
        /// <returns>returns the card for this turn after it is removed.</returns>
        public Card GetRandomCard(Random rng)
        {
            int index = rng.Next(0, cards.Count());
            Card c = cards[index];
            cards.RemoveAt(index);
            return c;
        }
        /// <summary>
        /// counts the remaining cards. 
        /// </summary>
        /// <returns>card count. </returns>
        public int CountRemainCards()
        {
            return cards.Count();
        }
        /// <summary>
        /// select the top fard in the deck and removes it. 
        /// </summary>
        /// <returns> the card its removing. (the top card) </returns>
        public Card GetTopCard()
        {
            Card c = cards[0];
            cards.RemoveAt(0);
            return c;
        }
    }
}
