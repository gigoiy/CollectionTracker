using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAlexKadyn
{
    public class Collection
    {
        // This is where the class for the info will be
        public string collectionName { get; set; }
        public string collectionValue { get; set; }

        public string[,] item = new string[100,100]; //starts 2d array, 1st will be the item name, 2nd will be the prices

        public override string ToString()
        {
            return collectionName;
        }
    }
}
