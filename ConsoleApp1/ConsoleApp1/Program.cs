using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Herf axtaricalaq cumleni daxil edin: ");
            string Sentence = Console.ReadLine();
            Console.Write("Axtarilacaq herfi daxil edin: ");
            char Letter = Convert.ToChar(Console.ReadLine());
            Search(Sentence, Letter);
        }
        static void Search(string Sentence, char Letter)
        {
            int total = 0;
            for (int i = 0; i < Sentence.Length; i++)
            {
                if (Sentence[i] == Letter)
                    total++;
                
            }
            if(total != 0)
                Console.WriteLine("Bu sozde "+ total +" eded " + Letter +" herfi var");
            else
            Console.WriteLine("Bu sozde " + Letter + " herfi yoxdur!" );
        }
    }
}
