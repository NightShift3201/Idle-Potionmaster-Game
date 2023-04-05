using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemSellButton : MonoBehaviour
{
    public GameObject statusBox;

    public void ClickTheButton(){
        if(GlobalPotions.redPotions ==0){
            statusBox.GetComponent<TextMeshProUGUI>().text = "Out of red potions";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
        }
        else{
            GlobalPotions.MoneyCount += 1;
            GlobalPotions.redPotions-=1;
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
