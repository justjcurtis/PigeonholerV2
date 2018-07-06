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
                int lowest = list[0];
                int index = 0;
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
    }
}
