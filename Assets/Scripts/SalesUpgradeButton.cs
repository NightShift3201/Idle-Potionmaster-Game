using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SalesUpgradeButton : MonoBehaviour
{

    public GameObject overlayButton;
    public GameObject overlayText;
    public GameObject button;
    public GameObject text;
    public int sellPrice;
    public static bool turnOffButton = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sellPrice  = (PurchaseLog.sellSpeed+1) *25;
        overlayText.GetComponent<TextMeshProUGUI>().text = "Auto Sell - "+PurchaseLog.sellSpeed+"  $" + sellPrice;
        text.GetComponent<TextMeshProUGUI>().text = "Auto Sell - "+PurchaseLog.sellSpeed+"  $" + sellPrice;
        if(GlobalPotions.MoneyCount>=sellPrice){
            overlayButton.SetActive(false);
            button.SetActive(true);
        }

        if(GlobalPotions.MoneyCount<sellPrice){
            button.SetActive(false);
            overlayButton.SetActive(true);
            turnOffButton = false;
        }

        if(turnOffButton == true)
        {
            button.SetActive(false);
            overlayButton.SetActive(true);
            turnOffButton = false;
        }
    }
}
