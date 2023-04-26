using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSell : MonoBehaviour
{
    public bool isSellingPotions = false;

    public Potion red;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!isSellingPotions){
            isSellingPotions = true;
            StartCoroutine(SellPotions());
        }
        
    }

    IEnumerator SellPotions()
    {
        if(red.amount>0){
            red.amount -= 1;
            GlobalPotions.MoneyCount += red.price;
        }

        

        yield return new WaitForSeconds(2f/(PurchaseLog.sellSpeed+1));
        isSellingPotions = false;
    }
}
