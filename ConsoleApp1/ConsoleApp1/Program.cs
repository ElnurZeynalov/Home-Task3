using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Herf axtaricalaq cumleni daxil edin: ");
            string x = Console.ReadLine();
            Console.Write("axtarilacaq herfi daxil edin: ");
            char y = Convert.ToChar(Console.ReadLine());
            Search(x,y);
        }
        static void Search(string cumle, char herf , int total=0)
        {
            for (int i = 0; i < cumle.Length; i++)
            {
                if (cumle[i] == herf)
                    total++;
                
            }
            if(total != 0)
                Console.WriteLine("Bu sozde "+ total +" eded " + herf +" herfi var");
            else
            Console.WriteLine("Bu sozde " + herf + " herfi yoxdur!" );
        }
    }
}
