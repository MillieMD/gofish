using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Human : Player
{
    public GameObject askingMenu;
    public InputField askingBox;
    public Button askingButton;
    public GameObject goFishButton;
    void Start()
    {
        askingMenu = GameObject.Find("/Main Game/HumanPlayerUI/Canvas/Asking").gameObject;
        askingBox = askingMenu.GetComponentInChildren<InputField>();
        askingButton = askingMenu.GetComponentInChildren<Button>();
        goFishButton = GameObject.Find("/Main Game/HumanPlayerUI/Canvas/GoFishButton").gameObject;

        askingMenu.SetActive(false);
        goFishButton.SetActive(false);

        askingButton.onClick.AddListener(delegate {RequestNumber(Convert.ToInt32(askingBox.text));});

        PlayerSetup();
    }

    public void TakeTurn(){
        askingMenu.SetActive(true);
    }

    public void RequestNumber(int i){
        GameObject.Find("Main Game").SendMessage("RequestNumber", i);
    }


    

}
