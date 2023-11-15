using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<Card> cards;
    public int finishedSets;

    public void PlayerSetup()
    {
        cards = new List<Card>();
        Debug.Log(name + " set up called now");

        var deck = GameObject.Find("Deck");
        deck.SendMessage("Deal", GameObject.Find(name));

        TempDebug();

        CountSets(); // Find and remove initial sets from hands

        //TempDebug();
    }

    public bool HasNumber(int number){
        foreach(Card card in cards){
            if(card.number == number){
                return true;
            }
        }

        return false;
    }

    public bool FindSet(int number){

        if(!HasNumber(number)){ // If it doesnt have the number it can't have the set
            return false;
        }

        int count = 0;
        List<Card> toRemove = new List<Card>();

        foreach(Card card in cards){
            if(card.number == number){
                count++;
                toRemove.Add(card);
            }
        }

        if(count == 4){
            foreach(Card card in toRemove){ // Remove cards so they aren't counted again
                cards.Remove(card);
            } 
            finishedSets++;
            return true;
            
        }

        return false;

    }

    public void CountSets(){

        for(int i = 1; i < 14; i++){
            FindSet(i);
        }

    }

    public void TempDebug(){
        foreach(Card card in cards){
            Debug.Log(name + ", " + card.ToString());
        }
    }

}
