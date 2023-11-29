using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War_Burmeister
{
    enum Suit
    {
        Diamonds,
        Spades,
        Clubs,
        Hearts,
    }

    enum Face
    {
        Ace = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
    }
    /// <summary>
    /// Represents a card in a deck. 
    /// </summary>
    class Card
    {
        /// <summary>
        /// suit of the card. 
        /// </summary>
        public Suit Suit { get; set; }
        /// <summary>
        /// face value of card.
        /// </summary>
        public Face Face { get; set; }
        /// <summary>
        /// Makes a new card with a new suit and face.
        /// </summary>
        /// <param name="suit">suit of a card.</param>
        /// <param name="face">face of the card.</param>
        public Card(Suit suit, Face face)
        {
            this.Suit = suit;
            this.Face = face;
        }
        /// <summary>
        /// Takes the 1st card and subtract other and returns positive, negative, or 0.
        /// </summary>
        /// <param name="other">other is literally the other card. So this card just takes the first card and other takes the other one.</param>
        /// <returns></returns>
        public int CompareTo(Card other)
        {
            return this.Face - other.Face;
        }
    }
}
