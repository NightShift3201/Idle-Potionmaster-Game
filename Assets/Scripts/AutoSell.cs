using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSell : MonoBehaviour
{
    public bool isSellingPotions = false;

    public Potion red;
    public Potion green;
    public Potion blue;
    public Potion golden;
    public Potion pink;


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
        
        green.amount -= 1;
        blue.amount -= 1;
        golden.amount -= 1;
        pink.amount -= 1;
        

        yield return new WaitForSeconds(2f/(PurchaseLog.sellSpeed+1));
        isSellingPotions = false;
    }
}
