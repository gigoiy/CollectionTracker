using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAlexKadyn
{
    public static class ItemSearch
    {
        public static int[] FindIndex(this Array collectionArray, object item)
        {
            if (collectionArray.Rank == 1)
                return new[] { Array.IndexOf(collectionArray, item) };

            var found = collectionArray.OfType<object>()
                              .Select((v, i) => new { v, i })
                              .FirstOrDefault(s => s.v.Equals(item));
            if (found == null)
                throw new Exception("Error: Item not found");

            var indexes = new int[collectionArray.Rank];
            var last = found.i;
            var lastLength = Enumerable.Range(0, collectionArray.Rank)
                                       .Aggregate(1,
                                           (a, v) => a * collectionArray.GetLength(v));
            for (var rank = 0; rank < collectionArray.Rank; rank++)
            {
                lastLength = lastLength / collectionArray.GetLength(rank);
                var value = last / lastLength;
                last -= value * lastLength;

                var index = value + collectionArray.GetLowerBound(rank);
                if (index > collectionArray.GetUpperBound(rank))
                    throw new IndexOutOfRangeException();
                indexes[rank] = index;
            }

            return indexes;
        }
    }
}
