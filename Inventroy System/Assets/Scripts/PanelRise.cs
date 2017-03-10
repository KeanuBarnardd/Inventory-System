using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PanelRise : MonoBehaviour , IPointerEnterHandler , IPointerExitHandler{
     
    //This will allow you to make the Panel Rise when the mouse Hovers over it
    private float riseSpeed = 5f;
    public Vector3 originalPosition;
    public Vector3 endPosition;

    private bool hovered;

	// Use this for initialization
	void Start () {
        // We set the Original Positions of the X and Y , so that we can return it to this Position
        originalPosition.x = transform.position.x;
        originalPosition.y = transform.position.y;
        //Sets the end Position 
        endPosition = transform.position;
        endPosition.y = transform.position.y + 10;
	}
	
	// Update is called once per frame
	void Update () {
        //Checks if if mouse is Over the Panel , then panel with move up until it reaches end position
        if (hovered)
        {
            if (transform.position.y < endPosition.y)
            {
                this.gameObject.transform.Translate(Vector3.up * Time.deltaTime * riseSpeed);
            }
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        hovered = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        hovered = false;
        transform.position = originalPosition;
    
    }
}
