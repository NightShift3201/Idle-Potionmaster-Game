using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoOrder : MonoBehaviour
{

    public bool isOrderingPotions = false;

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
        if(!isOrderingPotions){
            isOrderingPotions = true;
            StartCoroutine(OrderPotions());
        }
        
    }

    IEnumerator OrderPotions()
    {
        red.amount += red.orderAmount;
        green.amount +=green.orderAmount;
        blue.amount += blue.orderAmount;
        golden.amount += golden.orderAmount;
        pink.amount += pink.orderAmount;

        yield return new WaitForSeconds(2f/(PurchaseLog.speed+1));
        isOrderingPotions = false;
    }

    public void ResetTimer() {
        isOrderingPotions = false;
    }
}
