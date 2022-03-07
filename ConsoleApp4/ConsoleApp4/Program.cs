using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sahe medotlari:");
            Console.WriteLine("Cevrenin sahesinin tapilmasi ucun 1 e \n"+"Duzbucaqlinin sahesi ucun 2 e \n" +"Ucbucaqlinin daxiline cekilmis cevrenin sahesi ucun 3 e basin ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case (1):
                    Circle_Area();
                    break;
                case(2):
                    Rectangular_Area();
                break;
                case(3):
                    Circle_Area_Inside_Triangle();
                    break;

                default:
                    Console.WriteLine("1-3 arasi b");
                    break;
            }
            
        }
        static void Circle_Area() 
        {
            int pi = 3;
            int area = 0 ;
            Console.Write("Cevrenin radiusunu daxil edin: ");
            int r = Convert.ToInt32(Console.ReadLine());
            area = pi * r * r;
            Console.Write("Cevrenin sahesi: "+ area);
        }
        static void Rectangular_Area()
        {
            Console.Write("Duzbucaqlinin enini daxil edin : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Duzbucaqlinin uzunlugunu daxil edin : ");
            int b = Convert.ToInt32(Console.ReadLine());
            int area = 0;
            area = a*b;
            Console.Write("Duzbucaqlinin sahesi: " + area);
        }
        static void Circle_Area_Inside_Triangle()
        {
            Console.Write("Ucbucaqlinin 1-ci terefinin uzunlugunu daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ucbucaqlinin 2-ci terefinin uzunlugunu daxil edin: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ucbucaqlinin 3-cu terefinin uzunlugunu daxil edin: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int Circle_Perimeter = (a * b * c)/2;
            Console.Write("Cevrenin radiusunu daxil edin: ");
            int r = Convert.ToInt32(Console.ReadLine());
            int area = Circle_Perimeter * r;
            Console.WriteLine("Ucbucaqlinin daxiline cekilmis Cevrenin sahesi: " + area);

        }
    }
}