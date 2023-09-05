using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Deck : MonoBehaviour
{
    List<Card> cards = new List<Card>();
    
    // Initialise deck as 52 cards
    void Start()
    {
        string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades" };

        foreach (string suit in suits){

            for(int i = 1; i < 14; i ++){

                cards.Add(new Card(i,suit));
                
            }
        }
        cards.Shuffle();
    }

    void Deal(int noCards){ // This many cards to all players


    }

    // Card Draw(int n, gameObject targetPlayer){ // N cards to target player

    // }

}