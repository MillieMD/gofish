using System.Collections.Generic;
using UnityEngine;

public class MainGame : MonoBehaviour
{

    [SerializeField] private GameObject aiPlayerPrefab;
    [SerializeField] private GameObject humanPlayerPrefab;
    public List<GameObject> players {get; private set;}
    private GameObject deck;
    public GameObject currentPlayer {get; private set;}
    private int targetIndex = 0;

    void Start(){
        deck = GameObject.Find("/Main Game/Deck");
    }

    void InitilisePlayers(int noPlayers){

        players = new List<GameObject>();

        var humanPlayer = Instantiate(humanPlayerPrefab, new Vector3(), Quaternion.identity);
        humanPlayer.name = "Human Player";
        humanPlayer.transform.parent = transform;
        players.Add(humanPlayer);

        for(int i = 1; i <= noPlayers; i++){
            int rotate = i*90;

            var p = Instantiate(aiPlayerPrefab, new Vector3(0,0,0), Quaternion.Euler(0,rotate,0));
            p.name = "AI Player " + i;
            p.transform.parent = transform;

            players.Add(p);
        }

        currentPlayer = players[0];
        targetIndex = 1;
        currentPlayer.SendMessage("TakeTurn");

    }

    // void NextPlayer(){
    //     currentPlayer = players[players.IndexOf(currentPlayer) + 1];
    //     targetIndex = players.IndexOf(currentPlayer) + 1;

    //     currentPlayer.SendMessage("TakeTurn");

    // }

    // public void RequestNumber(int i){
    //     if(!players[targetIndex].GetComponent<Player>().HasNumber(i)){
    //         currentPlayer.SendMessage("GoFish");
    //         return;
    //     }
        
    //}

    
}
