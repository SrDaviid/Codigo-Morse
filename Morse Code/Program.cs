using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseFull
{
    class Program
    {
        public static int Tiempo;
        static void Main(string[] args)
        {
            foreach (var Words in args)
            {
                ContarSegundos(Words.ToLower());
            }
            Console.WriteLine("El traductor durará : " + Tiempo / 1000 + " segundos en presentar el mensaje en morse...");
            foreach (var Word in args)
            {

                Sonido(Word.ToLower());


            }

            Console.ReadLine();
        }
        public static void Sonido(string Word)
        {
            foreach (char Digit in Word.ToCharArray())
            {

                Console.WriteLine(Digit);
                try
                {
                    if (Digit == 'a')
                    {
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(750);
                    }
                    else if (Digit == 'b')
                    {
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(750);
                    }
                    else if (Digit == 'c')
                    {
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(750);
                    }
                    else if (Digit == 'd')
                    {
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(750);
                    }
                    else if (Digit == 'e')
                    {
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(750);
                    }
                    else if (Digit == 'f')
                    {
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(750);
                    }
                    else if (Digit == 'g')
                    {
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(750);
                    }
                    else if (Digit == 'h')
                    {
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(750);
                    }
                    else if (Digit == 'i')
                    {
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(750);
                    }
                    else if (Digit == 'j')
                    {
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(750);
                    }
                    else if (Digit == 'k')
                    {
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(750);
                    }
                    else if (Digit == 'l')
                    {
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(750);
                    }
                    else if (Digit == 'm')
                    {
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(750);
                    }
                    else if (Digit == 'n')
                    {
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(750);
                    }
                    else if (Digit == 'o')
                    {
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);

                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(750);
                    }
                    else if (Digit == 'p')
                    {
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(750);
                    }
                    else if (Digit == 'q')
                    {
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(750);
                    }
                    else if (Digit == 'r')
                    {
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(750);
                    }
                    else if (Digit == 's')
                    {
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(750);
                    }
                    else if (Digit == 't')
                    {
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(750);
                    }
                    else if (Digit == 'u')
                    {
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(750);
                    }
                    else if (Digit == 'v')
                    {
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(750);
                    }
                    else if (Digit == 'w')
                    {
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(750);
                    }
                    else if (Digit == 'x')
                    {
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(750);
                    }
                    else if (Digit == 'y')
                    {
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(750);
                    }
                    else if (Digit == 'z')
                    {
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(750);
                    }
                    else if (Digit == '1')
                    {
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(750);
                    }
                    else if (Digit == '2')
                    {
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(750);
                    }
                    else if (Digit == '3')
                    {
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(750);
                    }
                    else if (Digit == '4')
                    {
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(750);
                    }
                    else if (Digit == '5')
                    {
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(750);
                    }
                    else if (Digit == '6')
                    {
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(750);
                    }
                    else if (Digit == '7')
                    {
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(750);
                    }
                    else if (Digit == '8')
                    {
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine(".");
                        Console.Beep(600, 250);
                        System.Threading.Thread.Sleep(750);
                    }
                    else if (Digit == '9')
                    {
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(750);
                    }
                    else if (Digit == '0')
                    {
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("-");
                        Console.Beep(600, 750);
                        System.Threading.Thread.Sleep(750);
                    }
                    else if (Digit == ' ')
                    {
                        System.Threading.Thread.Sleep(1000);
                    }

                    else
                    {

                    }
                }
                catch
                {

                    Environment.Exit(0);
                }


            }

        }
        public static void ContarSegundos(string word)
        {
            foreach (char Digit in word.ToCharArray())
            {
                try
                {


                    if (Digit == 'a')
                    {
                        Tiempo = 2000 + Tiempo;
                    }
                    else if (Digit == 'b')
                    {
                        Tiempo = 3000 + Tiempo;
                    }
                    else if (Digit == 'c')
                    {
                        Tiempo = 3500 + Tiempo;
                    }
                    else if (Digit == 'd')
                    {
                        Tiempo = 2500 + Tiempo;
                    }
                    else if (Digit == 'e')
                    {
                        Tiempo = 1000 + Tiempo;
                    }
                    else if (Digit == 'f')
                    {
                        Tiempo = 3000 + Tiempo;
                    }
                    else if (Digit == 'g')
                    {
                        Tiempo = 3000 + Tiempo;
                    }
                    else if (Digit == 'h')
                    {
                        Tiempo = 2500 + Tiempo;
                    }
                    else if (Digit == 'i')
                    {
                        Tiempo = 1500 + Tiempo;
                    }
                    else if (Digit == 'j')
                    {
                        Tiempo = 4000 + Tiempo;
                    }
                    else if (Digit == 'k')
                    {
                        Tiempo = 3000 + Tiempo;
                    }
                    else if (Digit == 'l')
                    {
                        Tiempo = 3000 + Tiempo;
                    }
                    else if (Digit == 'm')
                    {
                        Tiempo = 2500 + Tiempo;
                    }
                    else if (Digit == 'n')
                    {
                        Tiempo = 2000 + Tiempo;
                    }
                    else if (Digit == 'o')
                    {
                        Tiempo = 3500 + Tiempo;
                    }
                    else if (Digit == 'p')
                    {
                        Tiempo = 3500 + Tiempo;
                    }
                    else if (Digit == 'q')
                    {
                        Tiempo = 4000 + Tiempo;
                    }
                    else if (Digit == 'r')
                    {
                        Tiempo = 2500 + Tiempo;
                    }
                    else if (Digit == 's')
                    {
                        Tiempo = 3000 + Tiempo;
                    }
                    else if (Digit == 't')
                    {
                        Tiempo = 1500 + Tiempo;
                    }
                    else if (Digit == 'u')
                    {
                        Tiempo = 2500 + Tiempo;
                    }
                    else if (Digit == 'v')
                    {
                        Tiempo = 3000 + Tiempo;
                    }
                    else if (Digit == 'w')
                    {
                        Tiempo = 3000 + Tiempo;
                    }
                    else if (Digit == 'x')
                    {
                        Tiempo = 3500 + Tiempo;
                    }
                    else if (Digit == 'y')
                    {
                        Tiempo = 4000 + Tiempo;
                    }
                    else if (Digit == 'z')
                    {
                        Tiempo = 3500 + Tiempo;
                    }
                    else if (Digit == '1')
                    {
                        Tiempo = 5000 + Tiempo;
                    }
                    else if (Digit == '2')
                    {
                        Tiempo = 4500 + Tiempo;
                    }
                    else if (Digit == '3')
                    {
                        Tiempo = 4000 + Tiempo;
                    }
                    else if (Digit == '4')
                    {
                        Tiempo = 3500 + Tiempo;
                    }
                    else if (Digit == '5')
                    {
                        Tiempo = 3000 + Tiempo;
                    }
                    else if (Digit == '6')
                    {
                        Tiempo = 3500 + Tiempo;
                    }
                    else if (Digit == '7')
                    {
                        Tiempo = 4000 + Tiempo;
                    }
                    else if (Digit == '8')
                    {
                        Tiempo = 4500 + Tiempo;
                    }
                    else if (Digit == '9')
                    {
                        Tiempo = 5000 + Tiempo;
                    }
                    else if (Digit == '0')
                    {
                        Tiempo = 5500 + Tiempo;
                    }
                    else
                    {
                        throw new System.ArgumentException();

                    }
                }

                catch (ArgumentException)
                {
                    Console.Error.WriteLine("Introdujo un valor no valido dentro del conjunto!...");
                }
            }
        }
    }
}