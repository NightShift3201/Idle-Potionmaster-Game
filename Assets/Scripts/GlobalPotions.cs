using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlobalPotions : MonoBehaviour
{

    public static int MoneyCount;
    public int InternalMoney;

    public static int redPotions;
    public int InternalRedPotions;


    public GameObject MoneyDisplay;
    public GameObject RedPotionDisplay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InternalRedPotions = redPotions;
        RedPotionDisplay.GetComponent<TextMeshProUGUI>().text = "Red Potions: " + InternalRedPotions;
        InternalMoney = MoneyCount;
        MoneyDisplay.GetComponent<TextMeshProUGUI>().text = "Balance: " + InternalMoney;
    }
}
