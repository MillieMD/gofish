using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public List<Card> cards {get; private set;}
    public bool canPickUp;
    void Start()
    {
        cards = new List<Card>();
        string[] suits = {"Hearts", "Clubs", "Diamonds", "Spades"};

        foreach(string suit in suits){

            for(int i = 1; i < 14; i++){

                cards.Add(new Card(i, suit));
            }
        }

        canPickUp = true;
    }

    public void Deal(GameObject player){

        Shuffle();
        
        for(int i = 0; i < 7; i++){

            player.GetComponent<Player>().cards.Add(cards[cards.Count-1]);
            cards.Remove(cards[cards.Count-1]);
        }

    }

    void Shuffle(){

        System.Random rnd = new System.Random();

        int n = cards.Count;
        while(n > 1){
            n--;
            int k = rnd.Next(n+1);
            var temp = cards[k];
            cards[k] = cards[n];
            cards[n] = temp;

        }

    }

    void OnMouseClick(){
        if(canPickUp){
            var currentPlayer = GameObject.Find("Main Game").GetComponent<MainGame>().currentPlayer.GetComponent<Player>();
            var currentPlayerCards = currentPlayer.cards;
            currentPlayerCards.Add(cards[cards.Count-1]);

            currentPlayer.TempDebug();
            canPickUp = false;
        }
    }


}
