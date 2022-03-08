using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Arrayin uzunlugunu teyin edin: ");
            int Array_Length = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[Array_Length];
            for (int i = 0; i < Array_Length; i++)
            {
                Console.Write(i+ ".Arrayin reqemlerini daxil edin: ");
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Axdarilacaq ereqemi daxil edin");
            int Wanted = Convert.ToInt32(Console.ReadLine());
            Search(Array, Wanted);
        }
        static void Search(int[] Array, int search)
        {
            int min = 0;
            int mid = 0;
            int max = Array.Length - 1;
            while (min<=max)
            {
                mid = (min + max) / 2;
                if (search == Array[mid])
                {
                    Console.WriteLine("Reqem arrayda movcuddur");
                    return;
                }
                  
                else if (search > Array[mid])
                    min = mid + 1;
                else
                    max = mid - 1;
            }
            Console.WriteLine("Reqem arrayda movcud deyil");
        }
    }
}
