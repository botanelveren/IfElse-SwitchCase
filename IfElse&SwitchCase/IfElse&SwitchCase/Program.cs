/*using System;

namespace IfElseSwitchCase
{
    class Program
    {
        static void Main(string[] args)

        {

            string apple = "elma";
            string pear = "armut";
            string strawberry = "çilek";
            string banana = "muz";
            string other = "diğer";



            Console.WriteLine("\nRüya Manavına Hoşgeldiniz!\n");
            Console.WriteLine("Elma = 2 TL");
            Console.WriteLine("Armut = 3 TL");
            Console.WriteLine("Çilek = 2 TL");
            Console.WriteLine("Muz = 3 TL");
            Console.WriteLine("Diğer bütün meyveler = 4 TL");
            Console.Write("Hangi meyveyi satın almak istersiniz? (Elma/Armut/Çilek/Muz/Diğer): ");

            string fruit = Console.ReadLine().ToLower();

            if (fruit == apple)
            {
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");

            }
            else if (fruit == pear)
            {
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
            }

            else if (fruit == strawberry)
            {
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
            }
            else if (fruit == banana)
            {
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
            }
            else
            {
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 TL");
            } */

////////////////////////////////////////////////////////////////////////////
//Above you can see the if/else version of the fruit selection/pricing program. Switch case let us define the list accurately so in this program using switch case is the better option.
////////////////////////////////////////////////////////////////////////////
using System;

enum fruits
{
    elma = 1 ,
    armut = 2,
    çilek = 3,
    muz = 4,
    diğer =5,
}

namespace IfElseSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nRüya Manavına Hoşgeldiniz!\n");
            Console.WriteLine("Elma = 2 TL");
            Console.WriteLine("Armut = 3 TL");
            Console.WriteLine("Çilek = 2 TL");
            Console.WriteLine("Muz = 3 TL");
            Console.WriteLine("Diğer bütün meyveler = 4 TL");
            Console.Write("Hangi meyveyi satın almak istersiniz? (1:Elma/2:Armut/3:Çilek/4:Muz/5:Diğer): ");
            int selection = int.Parse(Console.ReadLine());

            fruits selectedFruit = (fruits)selection;

            switch (selectedFruit)
            {
                case fruits.elma:
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
                    break;
                case fruits.armut:
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
                    break;
                case fruits.çilek:
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
                    break;
                case fruits.muz:
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
                    break;
                case fruits.diğer:
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 TL");
                    break;
                default:
                    Console.WriteLine("Geçersiz bir meyve seçtiniz.");
                    break;
            }
        }
    }
}
