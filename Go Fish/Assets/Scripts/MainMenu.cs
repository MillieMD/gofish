using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour
{

    [SerializeField] private Slider slider;
    [SerializeField] private TMP_Text sliderText;

    // Start is called before the first frame update
    void Start()
    {
        slider.onValueChanged.AddListener((v) =>{
            sliderText.text = v.ToString();
        });
    }

    public void PlayGame(){
        // Sends message to the game to create some players

        int noPlayers = (int) slider.value;
        GameObject mainGame = GameObject.Find("Main Game");

        mainGame.SendMessage("InitilisePlayers", noPlayers);
    }


}
