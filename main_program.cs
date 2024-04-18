using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;
using System.Media;

namespace who
{
    class Program
    {
        public static void Menu()
        {

            Console.CursorVisible = false;
            Game First = new Game();
            int stop = 0;
            ConsoleKeyInfo keypress;
            bool play = true;
            Console.BackgroundColor = ConsoleColor.White;
            //Console.WriteLine("   ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();
            Console.SetCursorPosition(119, 2);
            Console.WriteLine(@"
                     ▒█▀█▀█░▐█░▐█░▐█▀▀     ─░▄█▀▄─░▐█▀█▄▒▐▌▒▐▌░▐█▀▀▒██▄░▒█▌▒█▀█▀█▒█▒█▒▐█▀▀▄░▐█▀▀▒▄█▀▀█    
                     ░░▒█░░░▐████░▐█▀▀     ░▐█▄▄▐█░▐█▌▐█░▒█▒█░░▐█▀▀▒▐█▒█▒█░░░▒█░░▒█▒█▒▐█▒▐█░▐█▀▀▒▀▀█▄▄    
                     ░▒▄█▄░░▐█░▐█░▐█▄▄     ░▐█─░▐█░▐█▄█▀░▒▀▄▀░░▐█▄▄▒██░▒██▌░▒▄█▄░▒▀▄▀▒▐█▀▄▄░▐█▄▄▒█▄▄█▀ 


                             ▒▐█▀▀█▌░▐█▀▀     ▒▐██▄▒▄██▌░▐█▀▀▒▐█▀▀█▌▒█░░░▄░░▒█▒██░░░▒▀▄░░░░░▄▀
                             ▒▐█▄▒█▌░▐█▀▀     ░▒█░▒█░▒█░░▐█▀▀▒▐█▄▒█▌▒█░░▒█░░▒█▒██░░░░░▒▀▄░▄▀░░
                             ▒▐██▄█▌░▐█──     ▒▐█░░░░▒█▌░▐█▄▄▒▐██▄█▌░▒▀▄▀▒▀▄▀░▒██▄▄█░░░░▒█░░░░");
            Console.SetCursorPosition(15, 15);
            Console.WriteLine("New Game");
            Console.SetCursorPosition(15, 17);
            Console.WriteLine("Exit");
            keypress = Console.ReadKey(true);
            while (play)
            {
                switch (keypress.Key)
                {
                    case ConsoleKey.N:
                        {
                            Console.Clear();
                            //Console.WriteLine("Game");
                           First.AreaComplete();
                            //First.AddPlayer();
                            First.Print();
                            //Enemy1.Start();
                            Thread.Sleep(150);
                            //Enemy2.Start();
                            while (stop != 5 & stop!=7)
                            {
                                keypress = Console.ReadKey(true);
                                /*if (keypress.Key == ConsoleKey.N)
                                {
                                    //First.Clear();
                                    for (int i = 0; i < 10; i++)
                                    {

                                        int hitResult;
                                        First.Shoot(out hitResult);

                                    }
                                }*/
                                First.Movement(ref stop, ref keypress);
                            }
                            if (stop == 5)
                            {
                                Console.Clear();
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.SetCursorPosition(0, 12);
                                Console.WriteLine(@"
                                        ▄▀▀ ▄▀▄ ██▄██ █▀▀ . ▄▀▀▄ █░░░█ █▀▀ █▀▄
                                        █░█ █▄█ █░▀░█ █▀▀ . █░░█ ░█░█░ █▀▀ █▀▄
                                        ░▀▀ ▀░▀ ▀░░░▀ ▀▀▀ . ░▀▀░ ░░▀░░ ▀▀▀ ▀░▀");
                                Console.ReadLine();
                                play = false;
                            }
                            else if (stop == 7)
                            {
                                Console.Clear();
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.SetCursorPosition(0, 12);
                                Console.WriteLine(@"
                                        ▄▀▀ ▄▀▄ ██▄██ █▀▀ . ▄▀▀▄ █░░░█ █▀▀ █▀▄
                                        █░█ █▄█ █░▀░█ █▀▀ . █░░█ ░█░█░ █▀▀ █▀▄
                                        ░▀▀ ▀░▀ ▀░░░▀ ▀▀▀ . ░▀▀░ ░░▀░░ ▀▀▀ ▀░▀");
                                Console.SetCursorPosition(0, 19);
                                Console.WriteLine(@"
                                            █░█ ▄▀▀▄ █░░█ . █▀▄ ▀█▀ █▀▀ █▀▄
                                            ▀█▀ █░░█ █░░█ . █░█ ░█░ █▀▀ █░█
                                            ░▀░ ░▀▀░ ░▀▀░ . ▀▀░ ▀▀▀ ▀▀▀ ▀▀░");
                                Console.ReadLine();
                                play = false;
                            }
                        }
                        break;
                    //case ConsoleKey.H:
                    //    {
                    //        Console.Clear();
                    //        Console.WriteLine("Управление:\r\nW- назад\r\nS- вперед\r\nA- влево\r\nD - вправо\r\nE - взять предмет \r\nПробел - убрать блок/ предмет\r\n5 - выйти \r\n\nПравила:\r\nЧто бы начать нажми 4 раза вперед.\r\nПередвигайся по карте с помощью кнопок. Помоги Мяукли, обходя домики, собирая предметы и не попадая на шипы. У тебя 9 жизней, используй их с умом.\r\n\nПодсчет очков:\r\nШаг вперед +1\r\nШаг назад -2\r\nПопадание на шипы -10\r\nПодобрать m +50\r\nОт собранных тобой очков будет зависеть, конец игры.");
                    //    }
                    //    if (ConsoleKey.B == keypress.Key) { Menu(); }
                    //    break;
                    case ConsoleKey.E:
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.SetCursorPosition(0, 12);
                        Console.WriteLine(@"
                                        ▄▀▀ ▄▀▀▄ ▄▀▀▄ █▀▄ █▀▄ █░█ █▀▀
                                        █░█ █░░█ █░░█ █░█ █▀▄ ▀█▀ █▀▀
                                        ░▀▀ ░▀▀░ ░▀▀░ ▀▀░ ▀▀░ ░▀░ ▀▀▀");
                        Console.ReadLine();
                        play=false;
                        break;
                    default:
                        //Console.Clear();
                        Menu();
                        break;
                }
            }
            //Thread Enemy1 = new Thread(First.Enemy);
            //Thread Enemy2 = new Thread(First.Enemy2);


        }

        static void Main(string[] args)
        {

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "KickBack.wav";
            player.PlayLooping();

            Menu();

        }
    }
}
