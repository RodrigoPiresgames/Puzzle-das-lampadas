using System;

namespace LightPuzzle
{
    class Program
    {
        /// <summary>
        /// Onde o programa principal corre, cria 3 luzes e corre até ou o jogador ganhar ou até ficar sem tentativas
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //cria as 3 Luzes
            Light light1 = new Light();
            Light light2 = new Light();
            Light light3 = new Light();

            //numero maximo de tentativas
            int maxTries = 6;
            //contador de quantas tentativas foram feitas
            int currentTries = 0;

            //chama a função que explica as regras do jogo
            GiveRules();

            //ciclo principal do jogo
            while (currentTries < maxTries)
            {
                currentTries++;
                Console.WriteLine("Which button will you choose?");
                string option = Console.ReadLine();

                //switch que executa a mudança de estado da luzes de acordo com a opção do jogador
                switch (option)
                {
                    case "A":
                        Changelight(light1);
                        break;
                    case "S":
                        Changelight(light1);
                        Changelight(light2);
                        break;
                    case "D":
                        Changelight(light2);
                        Changelight(light3);
                        break;
                }

                //visualizaçao de como estao as luzes e quantas tentativas o jogador ainda tem
                Console.WriteLine($"{light1.ToImage()} {light2.ToImage()} {light3.ToImage()}");
                Console.WriteLine($"{light1.ToImage2()} {light2.ToImage2()} {light3.ToImage2()}");
                Console.WriteLine($"{light1.ToString()} {light2.ToString()} {light3.ToString()}");
                Console.WriteLine($"This is your {currentTries} try");

                //verificaçao se o jogo está ganho, chamando a funçao GameIsWon e se sim escreve que o jogador ganhou
                if (GameIsWon(light1, light2, light3) == true)
                {
                    Console.WriteLine(" (:)  (:)  (:)");
                    Console.WriteLine("  =    =    =");
                    Console.WriteLine("Congratulations!! You Win!!");
                    Console.WriteLine("         Game  Over");
                    break;
                }
            }

            //verificaçao se o jogo não está ganho, chamando a funçao GameIsWon e se não escreve que o jogador perdeu
            if (GameIsWon(light1, light2, light3) == false)
            {   
                Console.WriteLine(" ( )  ( )  ( )");
                Console.WriteLine("  =    =    =");
                Console.WriteLine("All lamps are off, you Lost...");
                Console.WriteLine("         Game  Over");
            }
        }

        /// <summary>
        /// A função recebe uma light e troca o seu valor, ligando e desligando a lux
        /// </summary>
        /// <param name="lightToChange">A luz que vai ser ter o seu valor alterado</param>
        static void Changelight(Light lightToChange)
        {
            lightToChange.turnOn = !lightToChange.turnOn;
        }

        /// <summary>
        /// A função que dá todas as informações ao player de como o jogo funciona
        /// </summary>
        static void GiveRules()
        {
            Console.WriteLine("Welcome to the Light Puzzle Game");
            Console.WriteLine("In this game you will have to solve a small puzzle by clicking buttons");
            Console.WriteLine("The objective is to have all the lights be turned on at the same time");
            Console.WriteLine("There's 3 buttons the you can choose");
            Console.WriteLine("All buttons act as a switch, they will change the state of their assigned button/s");
            Console.WriteLine("The button A has the first light assigned to it");
            Console.WriteLine("The button S has the first and second light assigned to it");
            Console.WriteLine("And finally, the button D has the second and third light assigned to it");
            Console.WriteLine("To choose a button you only have to type in A, S or D according to the button u wanna press");
            Console.WriteLine("");
            Console.WriteLine(" ( )  ( )  ( )");
            Console.WriteLine("  =    =    =");
        }

        /// <summary>
        /// A função que verifica se o jogo está ganho ou não
        /// </summary>
        /// <param name="x">A primeira luz</param>
        /// <param name="y">A segunda luz</param>
        /// <param name="z">A terceira luz</param>
        /// <returns>True ou false dependendo se o jogo está ou não ganho</returns>
        static bool GameIsWon (Light x, Light y, Light z)
        {
            if (x.turnOn && y.turnOn && z.turnOn == true)
                return true;
            return false;
        }
    }
}
