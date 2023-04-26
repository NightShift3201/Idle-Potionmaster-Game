using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{

    public static int speed = 0;
    public static int sellSpeed = 0;

    public  GameObject Controller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartAutoOrder(){
        Controller.GetComponent<AutoOrder>().enabled=true;
        GlobalPotions.MoneyCount-= (speed+1)*25;
        speed+=1;
        SpeedUpgradeButton.turnOffButton =true;
        
    }

}
