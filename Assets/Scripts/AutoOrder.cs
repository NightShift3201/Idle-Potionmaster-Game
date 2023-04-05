using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoOrder : MonoBehaviour
{

    public bool isOrderingPotions = false;
    public static int potionIncrease =1;
    public int internalIncrease;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        internalIncrease = potionIncrease;
        if(!isOrderingPotions){
            isOrderingPotions = true;
            StartCoroutine(OrderPotions());
        }
        
    }

    IEnumerator OrderPotions()
    {
        GlobalPotions.redPotions += internalIncrease;
        yield return new WaitForSeconds(2f/(PurchaseLog.speed+1));
        isOrderingPotions = false;
    }
}
