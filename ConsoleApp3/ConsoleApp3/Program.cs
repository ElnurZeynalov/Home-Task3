using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Arrayin uzunlugunu teyin edin: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] y = new int[x];
            for (int i = 0; i < x; i++)
            {
                Console.Write(i+ ".Arrayin reqemlerini daxil edin: ");
                y[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Axdarilacaq ereqemi daxil edin");
            int search = Convert.ToInt32(Console.ReadLine());
            Search(y, search);
        }
        static void Search(int[] y, int search)
        {
            int min = 0;
            int mid = 0;
            int max = y.Length - 1;
            while (min<=max)
            {
                mid = (min + max) / 2;
                if (search == y[mid])
                {
                    Console.WriteLine("Reqem Arrayda movcuddur");
                    return;
                }
                  
                else if (search > y[mid])
                    min = mid + 1;
                else
                    max = mid - 1;
            }
            Console.WriteLine("Reqem Movcud deyil");
        }
    }
}
