using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemSellButton : MonoBehaviour
{
    public GameObject statusBox;
    public int potionIndex;
    public static int redPrice = 1;
    public static int greenPrice = 5;
    public static int bluePrice = 10;
    public static int goldenPrice = 25;
    public static int pinkPrice = 50;


    public void sellPotion(int potionIndex){
        switch(potionIndex) {
            case 1:
                if(GlobalPotions.redPotions == 0){
                    statusBox.GetComponent<TextMeshProUGUI>().text = "Out of red potions";
                    statusBox.GetComponent<Animation>().Play("StatusAnim");
                }
                else{
                    GlobalPotions.MoneyCount += redPrice;
                    GlobalPotions.redPotions-=1;
                }
                break;
            
            case 2:
                if(GlobalPotions.greenPotions == 0){
                    statusBox.GetComponent<TextMeshProUGUI>().text = "Out of green potions";
                    statusBox.GetComponent<Animation>().Play("StatusAnim");
                }
                else{
                    GlobalPotions.MoneyCount += greenPrice;
                    GlobalPotions.greenPotions-=1;
                }
                break;

            case 3:
                if(GlobalPotions.bluePotions == 0){
                    statusBox.GetComponent<TextMeshProUGUI>().text = "Out of blue potions";
                    statusBox.GetComponent<Animation>().Play("StatusAnim");
                }
                else{
                    GlobalPotions.MoneyCount += bluePrice;
                    GlobalPotions.bluePotions-=1;
                }
                break;

            case 4:
                if(GlobalPotions.goldenPotions == 0){
                    statusBox.GetComponent<TextMeshProUGUI>().text = "Out of golden potions";
                    statusBox.GetComponent<Animation>().Play("StatusAnim");
                }
                else{
                    GlobalPotions.MoneyCount += goldenPrice;
                    GlobalPotions.goldenPotions-=1;
                }
                break;

            case 5:
                if(GlobalPotions.pinkPotions == 0){
                    statusBox.GetComponent<TextMeshProUGUI>().text = "Out of pink potions";
                    statusBox.GetComponent<Animation>().Play("StatusAnim");
                }
                else{
                    GlobalPotions.MoneyCount += pinkPrice;
                    GlobalPotions.pinkPotions-=1;
                }
                break;
            
            default:
                Debug.LogError("Invalid potion index");
                break;
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
