using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpeedUpgradeButton : MonoBehaviour
{

    public GameObject overlayButton;
    public GameObject overlayText;
    public GameObject button;
    public GameObject text;
    public int speedPrice;
    public static bool turnOffButton = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speedPrice  = (PurchaseLog.speed+1) *25;
        overlayText.GetComponent<TextMeshProUGUI>().text = "Buy Brewer - "+PurchaseLog.speed+"  $" + speedPrice;
        text.GetComponent<TextMeshProUGUI>().text = "Buy Brewer - "+PurchaseLog.speed+"  $" + speedPrice;
        if(GlobalPotions.MoneyCount>=speedPrice){
            overlayButton.SetActive(false);
            button.SetActive(true);
        }

        if(turnOffButton == true)
        {
            button.SetActive(false);
            overlayButton.SetActive(true);
            turnOffButton = false;
        }
    }
}
