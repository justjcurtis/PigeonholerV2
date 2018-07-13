using System.Collections.Generic;

namespace PigeonholerV2
{
    static class ListHelper
    {
        public static void SelectSort(this List<int> list)
        {
            var length = list.Count;
            for (int i = 0; i < length; i++)
            {
                var lowest = list[0];
                var index = 0;
                for (int j = 0; j < length - i; j++)
                {
                    if (lowest > list[j])
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
            for (int i = 0; i < length - 1; i++)
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

        public static void MergeSort(this List<int> list)
        {
            if (list.Count > 1)
            {
                var Split = splitList(list);
                Split[0].MergeSort();
                Split[1].MergeSort();
                list.Clear();
                list.AddRange(Merge(Split[0], Split[1]));
            }
        }

        private static List<int> Merge(List<int> a, List<int> b)
        {
            var finalLength = a.Count + b.Count;

            var result = new List<int>();

            int ia = 0, ib = 0;

            while (ia < a.Count || ib < b.Count)
            {
                if (ia < a.Count && ib < b.Count)
                {
                    if (a[ia] <= b[ib])
                    {
                        result.Add(a[ia]);
                        ia++;
                    }
                    else
                    {
                        result.Add(b[ib]);
                        ib++;
                    }
                }
                else if (ia < a.Count)
                {
                    result.Add(a[ia]);
                    ia++;
                }
                else if (ib < b.Count)
                {
                    result.Add(b[ib]);
                    ib++;
                }

            }
            return result;

        }

        private static List<List<int>> splitList(List<int> list)
        {
            var listLength = list.Count;

            var a = new List<int>();
            var b = new List<int>();

            for (int i = 0; i < listLength / 2; i++)
            {
                a.Add(list[i]);
            }
            for (int i = listLength / 2; i < listLength; i++)
            {
                b.Add(list[i]);
            }

            var result = new List<List<int>>
            {
                a,
                b
            };

            return result;
        }
    }
}
