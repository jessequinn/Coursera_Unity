using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// Programming Assignment 2 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Deals 2 cards to 3 players and displays cards for players
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // print welcome message
            Console.WriteLine("Welcome to the new version of BlackJack!!");

            // create and shuffle a deck
            Deck deck = new Deck();
            deck.Shuffle();
            
            // deal 2 cards each to 3 players (deal properly, dealing
            // the first card to each player before dealing the
            // second card to each player)
            Card[] p1 = new Card[2];
            Card[] p2 = new Card[2];
            Card[] p3 = new Card[2];
            
            p1[0] = deck.TakeTopCard();
            p2[0] = deck.TakeTopCard();
            p3[0] = deck.TakeTopCard();
            
            p1[1] = deck.TakeTopCard();
            p2[1] = deck.TakeTopCard();
            p3[1] = deck.TakeTopCard();
            
            // flip all the cards over
            for(int i =0; i < 2; i++)
            {
                p1[i].FlipOver();
                p2[i].FlipOver();
                p3[i].FlipOver();
            }

            // print the cards for player 1
            for (int i = 0; i < 2; i++)
            {
                if (p1[i].FaceUp)
                {
                    Console.WriteLine((1+i) + " card of Player 1: " + p1[i].Rank + " of " + p1[i].Suit);
                }
            }
            
            // print the cards for player 2
            for (int i = 0; i < 2; i++)
            {
                if (p2[i].FaceUp)
                {
                    Console.WriteLine((1+i) + " card of Player 2: " + p2[i].Rank + " of " + p2[i].Suit);
                }
            }
            
            // print the cards for player 3
            for (int i = 0; i < 2; i++)
            {
                if (p3[i].FaceUp)
                {
                    Console.WriteLine((1+i) + " card of Player 3: " + p3[i].Rank + " of " + p3[i].Suit);
                }
            }
            Console.WriteLine();
        }
    }
}
