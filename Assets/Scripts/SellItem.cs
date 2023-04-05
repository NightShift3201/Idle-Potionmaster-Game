using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellItem : MonoBehaviour
{

    public Item item;
    public Shopkeeper player;
    
    
    private void OnMouseDown()
    {
        player.balance+=item.price;
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
