using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigeonholerV2
{
    class Program
    {
        static void Main(string[] args)
        {
            var prog = new Program();
            prog.Run();
        }
        public void Run()
        {
            while (true)
            {
                var sel = getListOfInts();
                var ins = getListOfInts();
                var mrg = getListOfInts();
                var qck = getListOfInts();
                var success = string.Empty;

                Stopwatch s = new Stopwatch();

                Console.WriteLine("press enter to start select sort");
                Console.WriteLine(sel.IsSorted());
                Console.ReadLine();
                s.Start();
                sel.SelectSort();
                s.Stop();
                //foreach (var val in sel)
                //{
                //    Console.WriteLine(val);
                //}
                Console.WriteLine("");
                success = sel.IsSorted() ? "Sorting Successful" : "Sorting Unsuccessful";
                Console.WriteLine(success);
                Console.WriteLine($"Completed in {s.ElapsedTicks} ticks");
                s.Reset();
                Console.ReadLine();
                Console.WriteLine("===============================");
                Console.WriteLine("");
                Console.WriteLine("press enter to start insertion sort");
                Console.WriteLine(ins.IsSorted());
                Console.ReadLine();
                Console.WriteLine("");
                s.Start();
                ins.InsertionSort();
                s.Stop();
                //foreach (var val in ins)
                //{
                //    Console.WriteLine(val);
                //}
                Console.WriteLine("");
                success = ins.IsSorted() ? "Sorting Successful" : "Sorting Unsuccessful";
                Console.WriteLine(success);
                Console.WriteLine($"Completed in {s.ElapsedTicks} ticks");
                s.Reset();
                Console.ReadLine();
                Console.WriteLine("===============================");
                Console.WriteLine("");
                Console.WriteLine("press enter to start merge sort");
                Console.WriteLine(mrg.IsSorted());
                Console.ReadLine();
                Console.WriteLine("");
                s.Start();
                mrg.MergeSort();
                s.Stop();
                //foreach (var val in mrg)
                //{
                //    Console.WriteLine(val);
                //}
                Console.WriteLine("");
                success = mrg.IsSorted() ? "Sorting Successful" : "Sorting Unsuccessful";
                Console.WriteLine(success);
                Console.WriteLine($"Completed in {s.ElapsedTicks} ticks");
                s.Reset();
                Console.ReadLine();
                Console.WriteLine("===============================");
                Console.WriteLine("");
                Console.WriteLine("press enter to start quick sort");
                Console.WriteLine(qck.IsSorted());
                Console.ReadLine();
                Console.WriteLine("");
                s.Start();
                qck.QuickSort();
                s.Stop();
                //foreach (var val in qck)
                //{
                //    Console.WriteLine(val);
                //}
                Console.WriteLine("");
                success = qck.IsSorted() ? "Sorting Successful" : "Sorting Unsuccessful";
                Console.WriteLine(success);
                Console.WriteLine($"Completed in {s.ElapsedTicks} ticks");
                s.Reset();
                Console.ReadLine();
                Console.WriteLine("===============================");
                Console.WriteLine("");
                Console.WriteLine("press enter to start again");
                Console.ReadLine();
                Console.Clear();

            }
        }

        private List<int> getListOfInts()
        {
            var r = new Random();
            var result = new List<int>();
            for(int i = 0; i< 1000; i++)
            {
                result.Add(r.Next(0, 1000));
            }
            return result;
            //return new List<int> () { 25, 50, 46, 32, 23, 61, 3, 28, 25, 43, 48, 16, 90, 46, 96, 67, 9, 34, 20, 24, 2, 46, 35, 92, 2, 35, 96, 75, 17, 68, 70, 10, 27, 86, 80, 34, 88, 36, 20, 79, 33, 91, 29, 52, 81, 54, 4, 8, 52, 22, 70, 59, 99, 64, 59, 7, 53, 46, 77, 56, 40, 70, 85, 57, 94, 10, 33, 39, 66, 36, 12, 7, 29, 55, 15, 56, 17, 24, 86, 75, 98, 87, 65, 41, 8, 30, 70, 56, 44, 75, 20, 55, 64, 59, 15, 67, 4, 56, 78, 57 };
            
        }
    }
}
