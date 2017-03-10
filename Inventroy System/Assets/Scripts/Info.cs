using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Info : MonoBehaviour, IPointerClickHandler
{

    public string description;
    public Text descriptionBox;

    public void OnPointerClick(PointerEventData eventData)
    {   
        if(description != string.Empty)
        {
            descriptionBox.text = description;
            print(description);
        }
        else
        {
            print(gameObject.name + ": This item has nothing to say for itself.");
        }
    }
}
