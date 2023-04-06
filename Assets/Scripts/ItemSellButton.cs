using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemSellButton : MonoBehaviour
{
    public GameObject statusBox;
    public int potionIndex;
    public Potion potion;



    public void sellPotion(){
        if(potion.amount == 0){
            statusBox.GetComponent<TextMeshProUGUI>().text = "Out of "+potion.name+" potions";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
        }
        else{
            GlobalPotions.MoneyCount += potion.price;
            potion.amount-=1;
        }
        

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
