using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoOrder : MonoBehaviour
{

    public bool isOrderingPotions = false;
    public static int redPotionIncrease = 1;
    public static int greenPotionIncrease = 0;
    public static int bluePotionIncrease = 0;
    public static int goldenPotionIncrease = 0;
    public static int pinkPotionIncrease = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!isOrderingPotions){
            isOrderingPotions = true;
            StartCoroutine(OrderPotions());
        }
        
    }

    IEnumerator OrderPotions()
    {
        GlobalPotions.redPotions += redPotionIncrease;
        GlobalPotions.greenPotions +=greenPotionIncrease;
        GlobalPotions.bluePotions += bluePotionIncrease;
        GlobalPotions.goldenPotions += goldenPotionIncrease;
        GlobalPotions.pinkPotions += pinkPotionIncrease;

        yield return new WaitForSeconds(2f/(PurchaseLog.speed+1));
        isOrderingPotions = false;
    }

    public void ResetTimer() {
        isOrderingPotions = false;
    }
}
