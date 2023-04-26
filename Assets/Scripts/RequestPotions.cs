using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequestPotions : MonoBehaviour
{

    public GameObject Controller;
    public Potion red;
    public Potion green;
    public Potion blue;
    public Potion golden;
    public Potion pink;


    public void manualOrder(){
        red.amount += red.orderAmount;
        green.amount +=green.orderAmount;
        blue.amount += blue.orderAmount;
        golden.amount += golden.orderAmount;
        pink.amount += pink.orderAmount;
        //Controller.GetComponent<AutoOrder>().ResetTimer();

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
