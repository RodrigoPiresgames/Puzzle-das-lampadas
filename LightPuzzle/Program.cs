using System;

namespace LightPuzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            Light light1 = new Light();
            Light light1 = new Light();
            Light light1 = new Light();

            int maxTries = 6;
            int currentTries = 0;


            while (currentTries < maxTries)
            {
                Console.WriteLine("Gimme an -a- or -s- or -d-");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "a":
                        Changelight(1);
                        break;
                    case "s":
                        Changelight(1);
                        Changelight(2);
                        break;
                    case "d":
                        Changelight(2);
                        Changelight(3);
                        break;
                }

                currentTries++;

                Console.WriteLine($"{light1} {light2} {light3}");
            }
        }

        public void Changelight(int lightToChange)
        {
            if (lightToChange == 1)
                !light1.turnOn;
            else if (lightToChange == 2)
                !light2.turnOn;
            else if (lightToChange == 3)
                !light3.turnOn;
        }
    }
}
