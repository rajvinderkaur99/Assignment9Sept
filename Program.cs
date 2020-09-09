using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConArrayandYield
{
    class Program
    {
        static List<int> MyList = new List<int>();
        static void FillValues()
        {
            MyList.Add(1);
            MyList.Add(2);
            MyList.Add(3);
            MyList.Add(4);
            MyList.Add(5);
        }
        static void Main(string[] args)
        { 
                int[,] arr = new int[5, 2] { { 0, 0 }, { 1, 2 }, { 2, 5 }, { 3, 8 }, { 7, 9 } };
                FillValues();
                
                Console.WriteLine("--------Twodimentional array");
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Console.WriteLine($"a[{i},{j}] = {arr[i, j]}");
                    }
                }
                Console.WriteLine("-------Yield Example-------");
                foreach (var item in Filter())
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("-------Yield Running Total-------");
                foreach (var item in RunningTotal())
                {
                    Console.WriteLine(item);
                }

                Console.Read();

            }
            static IEnumerable<int> RunningTotal()
            {
                int runningTotal = 0;
                foreach (var item in MyList)
                {
                    runningTotal += item;
                    yield return (runningTotal);



                }
            }
            static IEnumerable<int> Filter()
            {
                foreach (var item in MyList)
                {
                    if (item > 3)
                    {
                        yield return item;
                    }



                }
            }
        }
 }

