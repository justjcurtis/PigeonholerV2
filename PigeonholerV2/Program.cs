using System;
using System.Collections.Generic;
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
            Console.WriteLine("Sorting...");
            while (true)
            {
                var list = getListOfInts();
                list.SelectSort();
                foreach (var val in list)
                {
                    Console.WriteLine(val);
                }
                Console.ReadLine();
            }
        }

        private List<int> getListOfInts()
        {
            var stringData = "25,50,46,32,23,61,3,28,25,43,48,16,90,46,96,67,9,34,20,24,2,46,35,92,2,35,96,75,17,68,70,10,27,86,80,34,88,36,20,79,33,91,29,52,81,54,4,8,52,22,70,59,99,64,59,7,53,46,77,56,40,70,85,57,94,10,33,39,66,36,12,7,29,55,15,56,17,24,86,75,98,87,65,41,8,30,70,56,44,75,20,55,64,59,15,67,4,56,78,57";

            var data = stringData.Split(',');

            var list = new List<int>();
            foreach (var s in data)
            {
                var S = Convert.ToInt16(s);
                list.Add(S);
            }
            return list;
        }
    }
}
