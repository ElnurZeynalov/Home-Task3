using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2 Ci taskin sertini tam basa dusmedim ona gore ikisinde yazdim :)");
            Console.Write("1) Array Uzunlugunu daxil edin: ");
            int Arr_Length =Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[Arr_Length];
            for (int i = 0; i < Arr_Length; i++)
            {
                Console.Write(i+ ".Arrayin reqemleri daxil edin: ");
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("2) Hesablanacaq Reqemi daxil edin: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            Arr_Sum(Array); 
            Num_Sum(Number);

        }
        static void Arr_Sum(int[] Array , int sum = 0)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                sum = sum + Array[i];
            }
            Console.WriteLine("Arrayin reqemlerinin cemi: "+sum);
        }
        static void Num_Sum(int Number , int sum = 0)
        {
            for (int i = 0; i <= Number; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(Number + " reqeme qeder olan reqemlerin cemi: " + sum);
        }

    }
}
