using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlobalPotions : MonoBehaviour
{

    public static int MoneyCount = 100;
    public int InternalMoney;

    public Potion red;
    public Potion green;
    public Potion blue;
    public Potion golden;
    public Potion pink;


    public GameObject MoneyDisplay;
    public GameObject RedPotionDisplay;
    public GameObject GreenPotionDisplay;
    public GameObject BluePotionDisplay;
    public GameObject GoldenPotionDisplay;
    public GameObject PinkPotionDisplay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RedPotionDisplay.GetComponent<TextMeshProUGUI>().text = "Red Potions: " + red.amount;
        GreenPotionDisplay.GetComponent<TextMeshProUGUI>().text = "Green Potions: " + green.amount;
        BluePotionDisplay.GetComponent<TextMeshProUGUI>().text = "Blue Potions: " + blue.amount;
        GoldenPotionDisplay.GetComponent<TextMeshProUGUI>().text = "Golden Potions: " + golden.amount;
        PinkPotionDisplay.GetComponent<TextMeshProUGUI>().text = "Pink Potions: " + pink.amount;

        InternalMoney = MoneyCount;
        MoneyDisplay.GetComponent<TextMeshProUGUI>().text = "Balance: " + InternalMoney;
    }
}
