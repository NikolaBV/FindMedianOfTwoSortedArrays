using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MedianOfTwoSortedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = { 1, 2 };
            int[] num2 = { 3, 4};
            FindMedianSortedArrays(num1, num2);
        }
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int i;
            int[] newArray = new int[nums1.Length + nums2.Length];
            Array.Copy(nums1, newArray, nums1.Length);
            Array.Copy(nums2, 0, newArray, nums1.Length, nums2.Length);

            if(newArray.Length % 2 == 0)
            {
                Console.WriteLine("Cheten");
            }
            else
            {
                Console.WriteLine("Necheten");
            }
            return 1;
        }
    }
}
