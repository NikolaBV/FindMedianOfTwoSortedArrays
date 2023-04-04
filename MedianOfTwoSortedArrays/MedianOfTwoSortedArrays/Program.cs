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
            int[] num1 = Array.Empty<int>();
            int[] num2 = { 1};
            Console.WriteLine(FindMedianSortedArrays(num1, num2));
        }
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if(nums1 == null && nums2 == null)
            {
                return 0;
            }
            else
            {
                double[] newArray = new double[nums1.Length + nums2.Length];
                Array.Copy(nums1, newArray, nums1.Length);
                Array.Copy(nums2, 0, newArray, nums1.Length, nums2.Length);
                double elementOne = newArray[(newArray.Length / 2) - 1];
                double elementTwo = newArray[(newArray.Length / 2)];

                if (newArray.Length <= 0)
                {
                    return 0;
                }
                else
                {
                    if (newArray.Length % 2 == 0)
                    {
                        if (elementOne == 0 || elementTwo == 0)
                        {
                            return 0;
                        }
                        return (elementOne + elementTwo) / 2;
                    }
                    else if (newArray.Length == 1)
                    {
                        return newArray[0];
                    }
                    else
                    {
                        elementOne = (newArray.Length / 2) + 1;
                        if (elementOne == 0)
                        {
                            return 0;
                        }
                        return elementOne;
                    }
                }
            }
        }
    }
}
