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
    public int internalRedPotions;

    public static int greenPotions;
    public int internalGreenPotions;

    public static int bluePotions;
    public int internalBluePotions;

    public static int goldenPotions;
    public int internalGoldenPotions;

    public static int pinkPotions;
    public int internalPinkPotions; 


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
        internalRedPotions = redPotions;
        RedPotionDisplay.GetComponent<TextMeshProUGUI>().text = "Red Potions: " + internalRedPotions;

        internalRedPotions = greenPotions;
        BluePotionDisplay.GetComponent<TextMeshProUGUI>().text = "Green Potions: " + internalBluePotions;

        internalRedPotions = bluePotions;
        GreenPotionDisplay.GetComponent<TextMeshProUGUI>().text = "Blue Potions: " + internalGreenPotions;

        internalRedPotions = goldenPotions;
        GoldenPotionDisplay.GetComponent<TextMeshProUGUI>().text = "Golden Potions: " + internalGoldenPotions;

        internalRedPotions = pinkPotions;
        PinkPotionDisplay.GetComponent<TextMeshProUGUI>().text = "Pink Potions: " + internalPinkPotions;


        InternalMoney = MoneyCount;
        MoneyDisplay.GetComponent<TextMeshProUGUI>().text = "Balance: " + InternalMoney;
    }
}
