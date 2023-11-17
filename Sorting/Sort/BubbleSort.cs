﻿using System;

namespace SortAndSearch
{
    public class BubbleSort : ISort
    {

        private static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }
        private static void Swap(ref char e1, ref char e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        public int[] Sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }

            return arr;
        }
    }
}
