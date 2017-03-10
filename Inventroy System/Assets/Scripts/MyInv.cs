using UnityEngine;
using System.Collections;
using Inv;
using UnityEngine.UI;

public class MyInv : MonoBehaviour {

    //Access the GameObject that holds the User Interface for Inventory Canvas
    public GameObject uiData;
    private GameObject[] inventoryUI;

    //Here is where we will add arrays of the Items we wish to add
    public HandItems[] handItems;

    //Sets min amount for items in Inventory
    private int i = 0;

	// Use this for initialization
	void Start () {

        //set the size of the "inventoryUI" array, to the number of children in the "ui data" gameobject - that way we dont have to manually add each item in the inspector
        inventoryUI = new GameObject[uiData.transform.childCount];

        //go through each item in ui data, and apply its info to the index of the inventory ui
        for (int i = 0; i < inventoryUI.Length; i++)
        {
                inventoryUI[i] = uiData.transform.GetChild(i).gameObject;
        }
    }

    //Generates a random item from our inventory UI array
    public HandItems GenerateRandomHandItem()
    {
        return handItems[Random.Range(0, handItems.Length)];
    }

    public void BtncreateItem()
    {
        if (i < inventoryUI.Length)
        {
            //calls the "DisplayData" function which will automatically set the UI elements to the randomly generated item -- AND randonly generates an item for us, how handy!
            //"GenerateRandomItem" returns a random item data (class), then that class has a extention for "DisplayData", which will take in all the UI elemtns of that index
            GenerateRandomHandItem().DisplayData(inventoryUI[i].transform.GetChild(0).GetComponent<Image>(), inventoryUI[i].transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Text>(), inventoryUI[i].GetComponent<Info>());
            i++;
        }
        else { print("Max inventory space reached."); }
    }
}


[System.Serializable]
public class HandItems {

    //Items that can only picked up with the Hand Tool
    //generic variables (data)
    public string name;
    public ItemType type;
    public enum ItemType { Banana , Coconut , Stick , Rock , Vine};
    public Sprite icon;
    [Multiline(12)]
    public string description;

    //function we are not using anymore - just returns all the info of the item, as a string, so we could print it to the console or something
    public string GetData()
    {
        return name + " (" + type + ")\n" + "\"<i>" + description + "</i>\"";
    }

    /// <summary>
    /// Set the UI elements passed in, automatically.
    /// </summary>
    /// <param name="imgObj">The image object from the UI array, to auto-apply the icon of the randomly generated item to.</param>
    /// <param name="txtObj">The text object from the UI array, to auto-apply the name of the randomly generated item to.</param>
    /// <param name="infoScript">The Info script from the UI array, to auto-apply the description, and type of the randomly generated item to.</param>
    public void DisplayData(Image imgObj, Text txtObj, Info infoScript ) {
        imgObj.sprite = icon;
        txtObj.text = name;
        infoScript.description =type + "\n" + description;
       
    } 
}
