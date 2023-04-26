using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PotionPriceIncrease : MonoBehaviour
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
        overlayText.GetComponent<TextMeshProUGUI>().text = "$" + (Mathf.Pow(potion.priceUpgradesBase, potion.priceUpgrades)+potion.priceUpgradesStart);
        text.GetComponent<TextMeshProUGUI>().text = "$" + (Mathf.Pow(potion.priceUpgradesBase, potion.priceUpgrades)+potion.priceUpgradesStart);

        if(GlobalPotions.MoneyCount>=(Mathf.Pow(potion.priceUpgradesBase, potion.priceUpgrades)+potion.priceUpgradesStart)){
            overlayButton.SetActive(false);
            button.SetActive(true);
        }

        if(GlobalPotions.MoneyCount<(Mathf.Pow(potion.priceUpgradesBase, potion.priceUpgrades)+potion.priceUpgradesStart)){
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
        GlobalPotions.MoneyCount-=(Mathf.Pow(potion.priceUpgradesBase, potion.priceUpgrades)+potion.priceUpgradesStart);
        potion.price +=potion.priceIncrease;
        potion.priceUpgrades+=1;
        turnOffButton=true;

    }
}
