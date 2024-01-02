using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EconomyManager : Singleton<EconomyManager>
{
    private TMP_Text goldText;
    private int currentGold = 0;

    const string COIN_AMOUNT_TEXT = "Gold Amount Text";

    public void UpdateCurrentGold() {
        currentGold += 1;
        ShowGold();
    }
    public bool AfterTrade()
    {
        if (currentGold < 50)
        {
            
            return false;
        }
        else
        {
            currentGold -= 50;
            ShowGold();
            return true;
        }
    }
    public void ShowGold()
    {
        if (goldText == null)
        {
            goldText = GameObject.Find(COIN_AMOUNT_TEXT).GetComponent<TMP_Text>();
        }

        goldText.text = currentGold.ToString("D3");
    }
}
