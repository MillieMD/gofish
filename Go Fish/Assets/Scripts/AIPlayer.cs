using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using TMPro;

public class AIPlayer : Player
{
    [SerializeField] private TMP_Text goFishText;
    [SerializeField] private TMP_Text askingText;
    void Start()
    {
        goFishText.GetComponent<TextMeshProUGUI>().enabled = false;
        askingText.GetComponent<TextMeshProUGUI>().enabled = false;

        PlayerSetup();
    }


}
