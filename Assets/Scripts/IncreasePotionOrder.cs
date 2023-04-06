using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasePotionOrder : MonoBehaviour
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

    public void increasePotion(int potionIndex){
        switch(potionIndex){
            case 1:
                AutoOrder.redPotionIncrease +=1;
                GlobalPotions.MoneyCount-=redPotionIncrease*50
                turnOffButton=true;
                break;
            case 2:
                AutoOrder.greenPotionIncrease +=1;
                GlobalPotions.MoneyCount-=greenPotionIncrease*50
                turnOffButton=true;
                break;
            case 3:
                AutoOrder.bluePotionIncrease +=1;
                GlobalPotions.MoneyCount-=bluePotionIncrease*50
                turnOffButton=true;
                break;
            case 4:
                AutoOrder.goldenPotionIncrease +=1;
                GlobalPotions.MoneyCount-=goldenPotionIncrease*50
                turnOffButton=true;
                break;
            case 5:
                AutoOrder.pinkPotionIncrease +=1;
                GlobalPotions.MoneyCount-=pinkPotionIncrease*50
                turnOffButton=true;
                break;
            default:
                Debug.LogError("Invalid potion index");
                break;
            

        }

    }
}
