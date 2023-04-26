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
    public bool turnOffButton = false;
    public bool isSellingPotions = false;
    public bool startSell = false;
    public Potion potion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        overlayText.GetComponent<TextMeshProUGUI>().text = potion.sellSpeed +"  $" + (potion.sellSpeed*potion.orderMultiplier+potion.orderMultiplier);
        text.GetComponent<TextMeshProUGUI>().text = potion.sellSpeed +"  $" + (potion.sellSpeed*potion.orderMultiplier+potion.orderMultiplier);

        if(GlobalPotions.MoneyCount>=potion.sellSpeed*potion.orderMultiplier+potion.orderMultiplier){
            overlayButton.SetActive(false);
            button.SetActive(true);
        }

        if(GlobalPotions.MoneyCount<potion.sellSpeed*potion.orderMultiplier+potion.orderMultiplier){
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
        if(!isSellingPotions&&startSell){
            isSellingPotions = true;
            StartCoroutine(SellPotions());
        }
    }

    public void upgradeAutoSell(){
        GlobalPotions.MoneyCount-=potion.sellSpeed*potion.orderMultiplier+potion.orderMultiplier;
        startSell = true;
        potion.sellSpeed +=1;
        turnOffButton=true;

    }
    IEnumerator SellPotions()
    {
        if(potion.amount>0){
            potion.amount -= 1;
            GlobalPotions.MoneyCount += potion.price;
        }

        

        yield return new WaitForSeconds(2f/(potion.sellSpeed+1));
        isSellingPotions = false;
    }
    
}
