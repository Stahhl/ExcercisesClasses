using System;
using System.Collections.Generic;

namespace ExcercisesClasses
{
    class Program
    {
        static List<Circle> circleList = new List<Circle>();
        static void Main()
        {
            //Method_6_1();
            //Method_6_2();
            //Method_6_4();
            Method_6_5();
        }
        static void Method_6_5()
        {
            Adress adress = new Adress("Norra Köpmangatan", 16, "Gävle", "803 11");

            Console.WriteLine("Method: " + adress.GetStreet());
            Console.WriteLine("Getter: " + adress.FullStreet);
            Console.WriteLine("Method - old zip: " + adress.GetZidCode());
            Console.WriteLine("Setter - old zip: " + adress.ZipCode);
            Console.Write("\nEnter a new zip: ");
            string input = Console.ReadLine();
            Console.WriteLine();
            adress.ChangeZidCode(input);
            adress.ZipCode = input;
            Console.WriteLine();
            Console.WriteLine("Method - new zip: " + adress.GetZidCode());
            Console.WriteLine("Setter - new zip: " + adress.ZipCode);
            Console.WriteLine();
            Main();
        }
        static void Method_6_4()
        {
            Person lisa = new Person("Lisa", "Persson", "1991-01-01", Gender.FEMALE, Sport.TENNIS, Sport.RUGBY);

            Console.WriteLine("Lisa is " + lisa.Gender);
            Console.WriteLine("Lisa likes to play " + lisa.FavoriteSport);
            Console.WriteLine("Lisa does not like to play: " + lisa.LeastFavoriteSport);
            Console.WriteLine();


            //Enumerate over an enum
            foreach (Sport sport in (Sport[])Enum.GetValues(typeof(Sport)))
            {
                Console.WriteLine($"* {sport}");
            }
            Console.WriteLine("\nEnter a sport: ");
            string input = Console.ReadLine();
            bool value = false;
            string[] strings = Enum.GetNames(typeof(Sport));
            //Enumerate over an enum
            foreach (Sport sport in (Sport[])Enum.GetValues(typeof(Sport)))
            {
                if (sport.ToString() == input.ToUpper())
                {
                    value = true;
                }
            }
            if (value == true)
            {
                Console.WriteLine("Oh i know " + input);
            }
            else
            {
                Console.WriteLine("Sorry, i don't know " + input);
            }
        }
        static void Method_6_2()
        {
            Cube mycube = new Cube(2, 3, 4);
            Cube supercube = new Cube(100, 200, 300);

            //myCube.WriteVolume();
            //supercube.WriteVolume();

            Console.WriteLine("Method: " + mycube.CalculateVolume());
            Console.WriteLine("Method: " + supercube.CalculateVolume());
            Console.WriteLine("Getter " + mycube.GetVolume);
            Console.WriteLine("Getter " + supercube.GetVolume);
        }
        static void Method_6_1()
        {
            circleList.Add(new Circle("Bob", 8));
            circleList.Add(new Circle("Lisa", 30));
            circleList.Add(new Circle("Edward"));
            circleList.Add(new Circle("Tomas"));
            circleList.Add(new Circle());
            circleList.Add(new Circle());


            foreach (Circle circle in circleList)
            {
                circle.SayHello();
            }

            Console.WriteLine();

            foreach (Circle circle in circleList)
            {
                circle.WriteArea();
            }
        }
    }
}


    //TENNIS,
    //RUGBY,
    //SOCCER,
    //HURLING,
    //SQUASH,
