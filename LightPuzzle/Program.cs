using System;

namespace LightPuzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            Light light1 = new Light();
            Light light2 = new Light();
            Light light3 = new Light();

            int maxTries = 6;
            int currentTries = 0;


            while (currentTries < maxTries)
            {
                Console.WriteLine("Gimme an -a- or -s- or -d-");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "a":
                        Changelight(light1);
                        break;
                    case "s":
                        Changelight(light1);
                        Changelight(light2);
                        break;
                    case "d":
                        Changelight(light2);
                        Changelight(light3);
                        break;
                }

                currentTries++;

                Console.WriteLine($"{light1.turnOn} {light2.turnOn} {light3.turnOn}");
            }
        }

        static void Changelight(Light lightToChange)
        {
            lightToChange.turnOn = !lightToChange.turnOn;
        }

    }
}
