using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IncreasePotionOrder : MonoBehaviour
{
    public GameObject overlayButton;
    public GameObject overlayText;
    public GameObject button;
    public GameObject text;
    public bool turnOffButton = false;
    public Potion potion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        overlayText.GetComponent<TextMeshProUGUI>().text = potion.orderAmount +"  $" + (potion.orderAmount*potion.orderMultiplier+potion.orderMultiplier);
        text.GetComponent<TextMeshProUGUI>().text = potion.orderAmount +"  $" + (potion.orderAmount*potion.orderMultiplier+potion.orderMultiplier);

        if(GlobalPotions.MoneyCount>=potion.orderAmount*potion.orderMultiplier+potion.orderMultiplier){
            overlayButton.SetActive(false);
            button.SetActive(true);
        }

        if(GlobalPotions.MoneyCount<potion.orderAmount*potion.orderMultiplier+potion.orderMultiplier){
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

    public void increasePotion(){
        GlobalPotions.MoneyCount-=potion.orderAmount*potion.orderMultiplier+potion.orderMultiplier;
        potion.orderAmount +=1;
        turnOffButton=true;

    }
}
