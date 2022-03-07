using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2 Ci taskin sertini tam basa dusmedim ona gore ikisinde yazdim :)");
            Console.Write("1) Array Uzunlugunu daxil edin: ");
            int n =Convert.ToInt32(Console.ReadLine());
            int[] z = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write(i+ ".Arrayin reqemleri daxil edin: ");
                z[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("2) Hesablanacaq Reqemi daxil edin: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Arr_Sum(z); 
            Num_Sum(y);
            //Ozum bilerek Z yazdim )

        }
        static void Arr_Sum(int[] a , int sum = 0)
        {
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine("Arrayin reqemlerinin cemi: "+sum);
        }
        static void Num_Sum(int y , int sum = 0)
        {
            for (int i = 0; i <= y; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(y + " reqeme qeder olan reqemlerin cemi: " + sum);
        }

    }
}
