using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAlexKadyn
{
    public class CollectionName
    {
        // This is where the class for the info will be
        public string collectionName { get; set; }
        public string collectionValue { get; set; }

        public string[,] item; //starts 2d array, 1st will be the item name, 2nd will be the price, description, and model#

        // made the constructor so that when the new collection is called, it will automatically be set
    }
}
