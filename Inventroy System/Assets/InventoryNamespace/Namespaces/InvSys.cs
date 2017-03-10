using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

namespace Inv
{
    
    public class ActiveBag
    {
        public List<Item> myBag;

        public void AddItem(Item itemData)
        {
            myBag.Add(itemData);
        }


        public string PrintItems()
        {
            string itemsAsString = "";

            foreach(Item item in myBag)
            {
                itemsAsString += item.GetData() + "\n";
            }

            return itemsAsString;
        }

    }

    #region old
    //public class Item
    //{
    //    public Item()
    //    {
    //        //constructor

    //    }

    //    public Item(Tool tool)
    //    {
    //        //constructor

    //    }

    //    public Item(Computer comp)
    //    {
    //        //constructor

    //    }




    //    public class Tool
    //    {
    //        public string toolType;
    //        public string purpose;
    //        public int price;

    //        public string GetData()
    //        {
    //            string toolData = "";

    //            toolData += toolType + "\n";
    //            toolData += "Purpose: " + purpose + "\n";
    //            toolData += "$" + price + " Market Price (before taxes)";

    //            return toolData;
    //        }
    //    };

    //    public struct Computer
    //    {
    //        public string model;
    //        public string brand;
    //        public int price;
    //    };

    //}
    #endregion




    //Base class
    [System.Serializable]
    public class Item
    {
        public virtual string Name { get; set; }
        
        public virtual string GetData() { return name; }

        public void GetAllData()
        {
           
        }

        public string name;
    }

    //Item Types classes
    public class Apple : Item
    {
        public int seeds;
        

        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
               
                    name = "New Apple";
            }
        }

        public override string GetData()
        {
            return name + "\n" + seeds;
        }
    }

    public class Phone : Item
    {
        public bool sold;
        

        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
               
                    name = "New Phone";
            }
        }

        public override string GetData()
        {
            return name + "\n" + sold;
        }
    }

}
