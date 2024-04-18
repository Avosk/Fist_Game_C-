using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;

namespace who
{
    



    class Game
    {
        char[,] Map = new char[1002, 102];
        int PL1_CoordinateUp = 0;
        int PL1_CoordinateDown = 50;
        int y = 0, ras = 0, obr = 4;
        //int Enemy_CoordUpDown = 1;
        //int Enemy_CoordLeftRight = 1;
        //int Enemy2_CoordUpDown = 3;
        //int Enemy2_CoordLeftRight = 10;
        //int HitCheck = 0;
        Random new_plase_x = new Random();
        Random new_plase_y = new Random();
        //int WhichEnemyIsHit = 0;
        public static char zv = '*', kv = '■', v_h = '/', v_h1 = '\\', n_h = '■', mon = 'o', gr = '║', m = 'm';
        public static int sim, str, n = 25, hart = 9, l = 0, m_count=0;



        private char[,] AreaGeneration()
        {
            for (int stroka = 0; stroka <= Map.GetLength(0) - 1; stroka++)
            {
                for (int simvol = 0; simvol <= Map.GetLength(1) - 1; simvol++)
                {
                    if (simvol == 101)
                        Map[stroka, simvol] = '\n';
                    else if (simvol == 0 | simvol == 100)
                    {
                        //a = stroka.ToString();
                        Map[stroka, simvol] = gr;
                    }


                    else
                    { Map[stroka, simvol] = ' '; }
                }

            }
            return Map;
        }

        public char[,] AreaComplete()
        {
            AreaGeneration();
            for (int stroka = 1; stroka <= Map.GetLength(0) - 2; stroka++)
            {
                for (int simvol = 1; simvol <= Map.GetLength(1) - 3; simvol++)
                {
                    //Random new_plase_x = new Random();
                    //Random new_plase_y = new Random();
                    sim = new_plase_x.Next(3, 97);
                    if (stroka % 15 == 0)
                    {
                        Map[stroka, simvol] = zv;
                    }


                    else if (stroka % 6 == 0 & sim % 7.5 == 0)
                    {
                        Map[stroka - 1, sim] = v_h;
                        Map[stroka - 1, sim + 1] = v_h1;
                        Map[stroka, sim] = n_h;
                        Map[stroka, sim + 1] = n_h;


                    }
                    //else if (stroka % 9 == 0 & sim % 3.5 == 0)
                    //{
                    //    Map[stroka - 1, sim] = zv;

                    //    Map[stroka, sim] = kv;
                    //}
                    /*   if
                           (simvol % 5 == 0 & stroka % 3 == 0)
                       {
                           Area[stroka, simvol] = '▓';
                           Area[stroka, simvol - 1] = '▓';
                           Area[stroka - 1, simvol] = '▓';
                           Area[stroka - 1, simvol - 1] = '▓';
                       }

                       else */


                }
            }
                for (int i = 0; i < 10; i++)
                {  sim = new_plase_x.Next(3, 97);
                    str = new_plase_x.Next(5, 1001);
                    if (Map[str, sim] == ' ')
                    { 
                        // Random new_plase_x = new Random();
                        //Random new_plase_y = new Random();
                        
                        Map[str, sim] = m;
                    }
                    else i--;
                }
            
            return Map;
            }

            //public void AddPlayer()
            //{
            //    Console.SetCursorPosition(PL1_CoordinateUp, PL1_CoordinateDown);
            //    Console.Write("0");
            //}

            private void MovementStart(ref int stop, ref int up, ref int down, ref ConsoleKeyInfo keypress)
            {
                int Dy = 0, Dx = 0;
                switch (keypress.Key)
                {
                    case ConsoleKey.W:
                        Dx--;
                        if (y != 0)
                        {
                            if (Map[y + Dx, PL1_CoordinateDown] == ' ' & Map[y + Dx, PL1_CoordinateDown + 1] == ' ' & Map[y + Dx, PL1_CoordinateDown + 2] == ' ' & Map[y + Dx, PL1_CoordinateDown + 3] == ' ' & Map[y + Dx, PL1_CoordinateDown + 4] == ' ' & Map[y + Dx, PL1_CoordinateDown + 5] == ' ' & Map[y + Dx, PL1_CoordinateDown + 6] == ' ')
                            {
                                //PL1_CoordinateUp--;
                                //up--;
                                n--;
                                y--;
                                l -= 2;
                                if (hart == 0) { stop = 5; }
                                Print();
                            }
                            else if (Map[y + Dx, PL1_CoordinateDown] == '*' | Map[y + Dx, PL1_CoordinateDown + 1] == '*' & Map[y + Dx, PL1_CoordinateDown + 2] == '*' & Map[y + Dx, PL1_CoordinateDown + 3] == '*' & Map[y + Dx, PL1_CoordinateDown + 4] == '*' & Map[y + Dx, PL1_CoordinateDown + 5] == '*' & Map[y + Dx, PL1_CoordinateDown + 6] == '*')
                            {
                                hart--;
                                l -= 10;

                                Print();
                            }

                            else
                            {
                                Console.SetCursorPosition(101, 6);
                                Console.WriteLine("Там дом!");
                            }
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(101, 4);
                            Console.WriteLine("Там нет карты!");

                        }
                        //Console.SetCursorPosition(101, 4);
                        //Console.WriteLine("x -{0}", y);
                        //Console.SetCursorPosition(101, 5);
                        //Console.WriteLine("y -{0}", PL1_CoordinateDown);
                        break;
                    case ConsoleKey.S:
                        if (ras > 3)
                        {
                            Dx++;
                            if (Map[y + Dx, PL1_CoordinateDown] == ' ' & Map[y + Dx, PL1_CoordinateDown + 1] == ' ' & Map[y + Dx, PL1_CoordinateDown + 3] == ' ' & Map[y + Dx, PL1_CoordinateDown + 4] == ' ' & Map[y + Dx, PL1_CoordinateDown + 5] == ' ' & Map[y + Dx, PL1_CoordinateDown + 6] == ' ')
                            {
                                // PL1_CoordinateUp++;
                                //up++;
                                n++;
                                y++;
                                l++;
                                Print();
                            }
                            else if (Map[y + Dx, PL1_CoordinateDown] == '*' | Map[y + Dx, PL1_CoordinateDown + 1] == '*' | Map[y + Dx, PL1_CoordinateDown + 2] == '*' | Map[y + Dx, PL1_CoordinateDown + 3] == '*' | Map[y + Dx, PL1_CoordinateDown + 4] == '*' | Map[y + Dx, PL1_CoordinateDown + 5] == '*' | Map[y + Dx, PL1_CoordinateDown + 6] == '*')
                            {
                                hart--;
                                l -= 10;
                                if (hart == 0) { stop = 7; }
                                Print();
                            }

                            else
                            {
                                Console.SetCursorPosition(101, 6);
                                Console.WriteLine("Там дом!");
                            }
                        }
                        else
                        {
                            //Console.Clear();
                            n++; ras++;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            if (obr == 1)
                            {
                                Console.SetCursorPosition(106, 6);
                                Console.WriteLine(" ████");
                                Console.SetCursorPosition(106, 7);
                                Console.WriteLine(" ██─█");
                                Console.SetCursorPosition(106, 8);
                                Console.WriteLine(" █──█");
                                Console.SetCursorPosition(106, 9);
                                Console.WriteLine(" ██─█");
                                Console.SetCursorPosition(106, 10);
                                Console.WriteLine(" ██─█");
                                Console.SetCursorPosition(106, 11);
                                Console.WriteLine(" ██─█");
                                Console.SetCursorPosition(106, 12);
                                Console.WriteLine(" ████");
                            }
                            if (obr == 2)
                            {
                                Console.SetCursorPosition(106, 6);
                                Console.WriteLine("██████");
                                Console.SetCursorPosition(106, 7);
                                Console.WriteLine("█────█");
                                Console.SetCursorPosition(106, 8);
                                Console.WriteLine("█─██─█");
                                Console.SetCursorPosition(106, 9);
                                Console.WriteLine("███──█");
                                Console.SetCursorPosition(106, 10);
                                Console.WriteLine("█──███");
                                Console.SetCursorPosition(106, 11);
                                Console.WriteLine("█────█");
                                Console.SetCursorPosition(106, 12);
                                Console.WriteLine("██████");
                            }
                            if (obr == 3)
                            {
                                Console.SetCursorPosition(106, 6);
                                Console.WriteLine("█████");
                                Console.SetCursorPosition(106, 7);
                                Console.WriteLine("█───█");
                                Console.SetCursorPosition(106, 8);
                                Console.WriteLine("███─█");
                                Console.SetCursorPosition(106, 9);
                                Console.WriteLine("█───█");
                                Console.SetCursorPosition(106, 10);
                                Console.WriteLine("███─█");
                                Console.SetCursorPosition(106, 11);
                                Console.WriteLine("█───█");
                                Console.SetCursorPosition(106, 12);
                                Console.WriteLine("█████");
                            }
                            if (obr == 4)
                            {
                                Console.SetCursorPosition(106, 6);
                                Console.WriteLine("██████");
                                Console.SetCursorPosition(106, 7);
                                Console.WriteLine("█─██─█");
                                Console.SetCursorPosition(106, 8);
                                Console.WriteLine("█─██─█");
                                Console.SetCursorPosition(106, 9);
                                Console.WriteLine("█────█");
                                Console.SetCursorPosition(106, 10);
                                Console.WriteLine("████─█");
                                Console.SetCursorPosition(106, 11);
                                Console.WriteLine("████─█");
                                Console.SetCursorPosition(106, 12);
                                Console.WriteLine("██████");
                            }
                            obr--;
                        }
                        //Console.SetCursorPosition(101, 4);
                        //Console.WriteLine("x -{0}", y);
                        //Console.SetCursorPosition(101, 5);
                        //Console.WriteLine("y -{0}", PL1_CoordinateDown);
                        //Console.SetCursorPosition(101, 6);
                        //Console.WriteLine("dop shagi -{0}", ras);
                        break;
                    case ConsoleKey.A:
                        Dy--;
                        if (Map[y, PL1_CoordinateDown + Dy] == ' ')
                        {
                            PL1_CoordinateDown--;
                            down--;
                        }
                        else if (Map[y, PL1_CoordinateDown + Dy] == '*')
                        {
                            hart--;
                            l -= 10;
                            Print();
                            if (hart == 0) { stop = 5; }
                        }
                        //Console.SetCursorPosition(101, 4);
                        //Console.WriteLine("x -{0}", y);
                        //Console.SetCursorPosition(101, 5);
                        //Console.WriteLine("y -{0}", PL1_CoordinateDown);
                        break;
                    case ConsoleKey.D:
                        Dy += 7;
                        if (Map[y, PL1_CoordinateDown + Dy] == ' ')
                        {
                            PL1_CoordinateDown++;
                            down++;
                        }
                        else if (Map[y, PL1_CoordinateDown + Dy] == '*')
                        {
                            hart--;
                            l -= 10;
                            if (hart == 0) { stop = 5; }
                            Print();
                        }
                        //Console.SetCursorPosition(101, 4);
                        //Console.WriteLine("x -{0}", y);
                        //Console.SetCursorPosition(101, 5);
                        //Console.WriteLine("y -{0}", PL1_CoordinateDown);
                        break;

                    case ConsoleKey.NumPad5:
                        stop = 5;
                        break;
                    case ConsoleKey.Spacebar:
                        if (Map[y + 1, PL1_CoordinateDown + 3] == '*')
                        {
                            //// PL1_CoordinateUp++;
                            ////up++;
                            //n++;
                            //y++;
                            //l++;

                            Map[y + 1, PL1_CoordinateDown + 3] = ' ';
                            Print();
                        }
                        else if (Map[y + 1, PL1_CoordinateDown + 3] == '/' | Map[y + 1, PL1_CoordinateDown + 3] == '\\')
                        {
                            Console.SetCursorPosition(101, 7);
                            Console.WriteLine("Это не безапасно!");
                        }
                        else if (Map[y + 1, PL1_CoordinateDown + 3] == m)
                        {
                            //l += 50;
                        Map[y + 1, PL1_CoordinateDown + 3] = ' ';
                           // m_count++; 
                        Print();
                        }
                        //Console.SetCursorPosition(101, 8);
                        //Console.WriteLine("x -{0}", y);
                        //Console.SetCursorPosition(101, 9);
                        //Console.WriteLine("y -{0}", PL1_CoordinateDown) ;
                        break;
                case ConsoleKey.E:
                    if (Map[y + 1, PL1_CoordinateDown + 3] == m)
                    {
                        l += 50;
                        Map[y + 1, PL1_CoordinateDown + 3] = ' ';
                        m_count++;
                        Print();
                    }
                    break;
                default:
                        break;
                }
                return;
            }

            public void Movement(ref int stop, ref ConsoleKeyInfo keypress)
            {
                int up1 = 0, down1 = 0;
                Thread.Sleep(111);
                MovementStart(ref stop, ref up1, ref down1, ref keypress);

                if (Map[PL1_CoordinateUp, PL1_CoordinateDown] == ' ')
                {

                    Console.SetCursorPosition(PL1_CoordinateDown - down1, PL1_CoordinateUp);
                    Console.Write("       ");
                    Console.BackgroundColor = ConsoleColor.White;
                    //Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;

                    Console.SetCursorPosition(PL1_CoordinateDown, PL1_CoordinateUp);
                    Console.Write("=^._.^=");//работает по левым усам
                }
            }
           

            public void Print()
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;

                for (int stroka = 0; stroka <= Map.GetLength(0) - 1 & stroka != n; stroka++)
                {
                    for (int simvol = 0; simvol <= Map.GetLength(1) - 1; simvol++)
                    {
                        Console.Write(Map[stroka, simvol]);
                    }

                }
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.SetCursorPosition(101, 1);
                Console.Write("\t  Счет: {0}", l);
                Console.SetCursorPosition(102, 2);
                Console.ForegroundColor = ConsoleColor.Red;
                for (int i = 0; i < hart; i++)
                {
                    Console.Write("♥ ");
                }
            Console.SetCursorPosition(102, 3);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            for (int i = 0; i < m_count; i++)
            {
                Console.Write("{0}", m);
            }
            Console.ResetColor();
                //Console.WriteLine("Нажмите 5 для выхода из приложения\n");
            }
        }
    } 

