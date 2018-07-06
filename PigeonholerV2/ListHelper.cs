using System;
using System.Collections.Generic;

namespace PigeonholerV2
{
    static class ListHelper
    {
        public static void SelectSort(this List<int> list)
        {
            var length = list.Count;
            for(int i = 0; i < length; i++)
            {
                var lowest = list[0];
                var index = 0;
                for (int j = 0; j < length - i; j++)
                {
                    if(lowest > list[j])
                    {
                        lowest = list[j];
                        index = j;
                    }
                }
                list.Add(lowest);
                list.RemoveAt(index);
            }
        }

        public static void InsertionSort(this List<int> list)
        {
            var length = list.Count;
            var store = 0;
            for (int i = 0; i < length-1; i++)
            {
                if (list[i] > list[i + 1])
                {
                    store = list[i + 1];
                    list.RemoveAt(i + 1);
                    list.Insert(i, store);
                    i = -1;
                }
            }
        }
    }
}
