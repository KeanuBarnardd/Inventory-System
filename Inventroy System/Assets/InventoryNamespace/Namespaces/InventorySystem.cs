using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Inventory
{

    public class Items
    {
        List<Drug> drugs;

        private int minIndex = 0;

        public int GetMinIndex()
        {
            return minIndex;
        }

        public Items()
        {
            //constructor
            drugs = new List<Drug>();
        }

        public void CreateItem(Drug drugData)
        {
            drugs.Add(drugData);
            minIndex++;
        }

        public string GetAllItems()
        {
            string listedItems = "";

            foreach (Drug item in drugs)
            {
                listedItems += item.common.name + " (" + item.quality + " Quality)\n";
                listedItems += item.grams + " g\n";
                listedItems += "$" + item.price + " (per gram)\n\n";
            }

            listedItems = listedItems.Substring(0, listedItems.Length - 2); //remove the last 2 line breaks

            return listedItems;
        }


        [System.Serializable]
        public class GenericData
        {
            public string name;
            public Sprite icon;
            public GameObject gameObject;
        }

        [System.Serializable]
        public class Drug
        {
            public GenericData common;
            
            public float grams;
            public QualityType quality;
            public enum QualityType { Fake, KnockOff, Lowest, Low, Average, High, Highest };
            public int price;

            public Drug()
            {
                //constructor
                //we only need this one to exist, but we dont need any info in it
            }


            /// <summary>
            /// Generate the price of this drug, based on its quality level.
            /// </summary>
            /// <param name="basePrice">The base price this item will be sold for - the value generated, will be added onto this number. If you are unsure, set to 0.</param>
            /// <returns></returns>
            public int GeneratePriceByQuality(int basePrice)
            {
                int generatedPrice = 0;

                //prices per "gram".
                if(quality == QualityType.Fake) { generatedPrice = 20; } //Fake weed is the lowest possible kind and easy to tell it wont REALLY get you high, so its often sold very cheap
                if (quality == QualityType.KnockOff) { generatedPrice = 2900; } //Knock off weed is often hard to tell by looking at it, and therefore can pass as high quality and be sold for more
                if (quality == QualityType.Lowest) { generatedPrice = 73; } //Lowest quality weed is often easy to make, and cheap to sell, so it sells fast
                if (quality == QualityType.Low) { generatedPrice = 200; } //Low weed will get you high, but not for very long
                if (quality == QualityType.Average) { generatedPrice = 850; } //Average is most common, and will get you high for some time, but crappy crashes
                if (quality == QualityType.High) { generatedPrice = 1300; } //High weed is quick at getting you high and lasts a while, but take a while to get
                if (quality == QualityType.Highest) { generatedPrice = 3200; } //Highest weed is dangerous but also the most fun, and could keep you high for days, also nearly impossible to get

                return basePrice + generatedPrice;
            }
            
        }

    }
    
}
