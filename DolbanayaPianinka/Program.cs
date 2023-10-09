using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolbanayaPianinka
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("             эта наша  ПиАнИнКа               ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("если что! черные клавиши: R, T, Y, U, I"); //пять штучек~
            Console.WriteLine("если что! белые клавиши: D, F, G, H, J, K, L"); //семь штучек~
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("клавишки переключение актавочек F1,F2,F3 ");


            int[] firstOctave = { /* C бел */523, /* C# черн */554, /* D бел */587, /* Eb черн */622,
                /* E бел */659, /* F бел */698, /* F# черн */740, /* G бел */784, /* G# черн */830,
                /* A бел */880, /* Bb черн */932, /* B бел*/987 };

            //я написала это чисто для себя ибо слегка запуталась

            while (true)
            {
                ConsoleKeyInfo klavishka = Console.ReadKey(true);
                switch (klavishka.Key)
                {
                    case ConsoleKey.F1:  
                        Console.WriteLine("                                              ");
                        Console.WriteLine("~~~~~~~~~~ эта первая актавочка ~~~~~~~~~~~~~~");
                        firstOctave = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
                        break;
                    case ConsoleKey.F2:
                        Console.WriteLine("                                              ");
                        Console.WriteLine("~~~~~~~~~~ эта вторая актавочка ~~~~~~~~~~~~~~");
                        firstOctave = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
                        break;
                    case ConsoleKey.F3:  
                        Console.WriteLine("                                              ");
                        Console.WriteLine("~~~~~~~~~~ эта третья актавочка ~~~~~~~~~~~~~~");
                        firstOctave = new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
                        break;

                    case ConsoleKey.R:
                        Console.Beep(firstOctave[0], 100);
                        break;

                                case ConsoleKey.D:
                                    Console.Beep(firstOctave[1], 100);
                                    break;

                                        case ConsoleKey.T:
                                            Console.Beep(firstOctave[2], 100);
                                            break;

                                                case ConsoleKey.F:
                                                    Console.Beep(firstOctave[3], 100);
                                                    break;

                                        case ConsoleKey.Y:
                                            Console.Beep(firstOctave[4], 100);
                                            break;

                                case ConsoleKey.G:
                                    Console.Beep(firstOctave[5], 100);
                                    break;

                    case ConsoleKey.U:
                        Console.Beep(firstOctave[6], 100);
                        break;

                                case ConsoleKey.H:
                                    Console.Beep(firstOctave[7], 100);
                                    break;

                                        case ConsoleKey.I:
                                            Console.Beep(firstOctave[8], 100);
                                            break;

                                                case ConsoleKey.J:
                                                    Console.Beep(firstOctave[9], 100);
                                                    break;

                                        case ConsoleKey.K:
                                            Console.Beep(firstOctave[10], 100);
                                            break;

                                case ConsoleKey.L:
                                    Console.Beep(firstOctave[11], 100);
                                    break;

                }   /*достаточно оригинально расположила кейсы????
             я старалась, честна */

            }
        }
    }
}
