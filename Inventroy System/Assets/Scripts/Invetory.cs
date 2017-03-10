using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Invetory : MonoBehaviour {

    [Multiline(20)]
    public string allMyItems;
    
    public Item2[] items;

    // Use this for initialization
    void Start () {
        //print(items.ShowAll());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

[System.Serializable]
public class Item2
{
    public string name;
    public enum itemType { };
    public itemType type;
    

   //public string ShowAll()
   // {
   //     return 
   // }


    
    public class Fruits
    {
        public Apple apple;
        public Orange orange;
        public Pineapple pineapple;

        public Fruits()
        {
            //consrtructor
            apple = new Apple();
            orange = new Orange();
            pineapple = new Pineapple();
        }

        [System.Serializable]
        public struct Apple
        {
            public int seeds;
        }
        [System.Serializable]
        public struct Orange
        {
            public int layers;
        }
        [System.Serializable]
        public struct Pineapple
        {
            public float flavour;
        }
    }

    [System.Serializable]
    public class Electronics
    {
        public Cellphone cellphone;
        public Computer computer;
        public Microphone microphone;

        public Electronics()
        {
            cellphone = new Cellphone();
            computer = new Computer();
            microphone = new Microphone();
        }

        [System.Serializable]
        public struct Cellphone
        {
            public int price;
        }
        [System.Serializable]
        public struct Computer
        {
            public string model;
        }
        [System.Serializable]
        public struct Microphone
        {
            public float quality;
        }
    }
}
