using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequestPotions : MonoBehaviour
{

    public GameObject Controller;


    public void manualOrder(){
        GlobalPotions.redPotions += AutoOrder.redPotionIncrease;
        GlobalPotions.greenPotions +=AutoOrder.greenPotionIncrease;
        GlobalPotions.bluePotions += AutoOrder.bluePotionIncrease;
        GlobalPotions.goldenPotions += AutoOrder.goldenPotionIncrease;
        GlobalPotions.pinkPotions += AutoOrder.pinkPotionIncrease;
        Controller.GetComponent<AutoOrder>().ResetTimer();

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
