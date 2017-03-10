using UnityEngine;
using System.Collections;
using Inventory;
using System.Collections.Generic;

public class MyInventory : MonoBehaviour {

    [Multiline(15)]
    public string allMyItems;
    
    public List<Items.Drug> drugz;

    // Use this for initialization
    void Start () {
        Items itemsList = new Items();

        Items.Drug drugData = new Items.Drug();

        for (int i = 0; i < 2; i++)
        {
            drugz[i].price = drugz[i].GeneratePriceByQuality(drugz[i].price);

            drugData = drugz[i];
            
            itemsList.CreateItem(drugData);

            print("Min Index: " + itemsList.GetMinIndex());
        }

        allMyItems = itemsList.GetAllItems();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
