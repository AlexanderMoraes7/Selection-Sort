using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vtShuffled = { 951, 753, 7, 351, 3, 157, 5, 654, 1, 456, 9, 741, 2, 152, 8, 457, 4, 983, 6, 159, 753 };
            Order(vtShuffled);
            for (int i = 0; i <  vtShuffled.Length; i++)
            {
                Console.WriteLine(vtShuffled[i]);
            }
        }
        public static int[] Order(int[] items) {
            int totalItems = items.Length;

            for (int i = 0; i < totalItems -1; i++)
            {
                int posSmallerItem = i;
                for (int j = i + 1; j < totalItems; j++) {
                    if (items[j] < items[posSmallerItem])
                        posSmallerItem = j;
                }
                int temp = items[posSmallerItem];
                items[posSmallerItem] = items[i];
                items[i] = temp;
            }
            return items;
        }
    }
}
