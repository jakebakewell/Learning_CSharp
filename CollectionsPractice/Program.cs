using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] numArray = {0,1,2,3,4,5,6,7,8,9};
            string[] nameArray = new string[4];
            nameArray[0] = "Tim";
            nameArray[1] = "Martin";
            nameArray[2] = "Nikki";
            nameArray[3] = "Sara";
            bool[] boolArray = {true, false, true, false, true, false, true, false, true, false};
            List<string> flavors = new List<string>();
            flavors.Add("chocolate");
            flavors.Add("vanilla");
            flavors.Add("strawberry");
            flavors.Add("rocky road");
            flavors.Add("cookie dough");
            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);
            flavors.Remove("strawberry");
            Console.WriteLine(flavors.Count);
            Dictionary<string,string> favFlavors = new Dictionary<string,string>();
            favFlavors.Add("Tim", "vanilla");
            favFlavors.Add("Nikki", "chocolate");
            favFlavors.Add("Martin", "cookie dough");
            favFlavors.Add("Sara", "rocky road");
            foreach (KeyValuePair<string,string> entry in favFlavors) {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}
