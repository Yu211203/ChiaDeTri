using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class Program
    {

        static int binarySearch(int[] arr, int l,
                           int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                if (arr[mid] == x)
                    return mid;
                if (arr[mid] > x)
                    return binarySearch(arr, l, mid - 1, x);

                return binarySearch(arr, mid + 1, r, x);
            }

            return -1;
        }
        static void Main(string[] args)
        {

            int[] arr = { 1, 2, 6, 3, 8, 23, 12 };
            int n = arr.Length;
            int x;
            Array.Sort(arr);


            Console.Write("Original array : ");
            foreach (int i in arr) Console.Write(" " + i);
            Console.WriteLine();
            Console.Write("What element do you want to search: ");
            x = int.Parse(Console.ReadLine());
            int result = binarySearch(arr, 0, n - 1, x);
            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at index "
                                  + result);
            Console.ReadKey();
        }
    }
}

