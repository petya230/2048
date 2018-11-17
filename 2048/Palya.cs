using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    class Palya
    {
        public int[,] palya = new int[4, 4];

        public void FelEpit()
        {
            for (int i = 0; i < palya.GetLength(0); i++)
            {
                for (int j = 0; j < palya.GetLength(1); j++)
                {
                    palya[i, j] = 0;
                }
            }
            KezdoSzam();
        }
        public void KezdoSzam()
        {
            Random rnd = new Random();
            palya[rnd.Next(0, 4), rnd.Next(0, 4)] = 2;
        }
        public void Kiir()
        {
            Console.Clear();
            for (int i = 0; i < palya.GetLength(0); i++)
            {
                for (int j = 0; j < palya.GetLength(1); j++)
                {
                    switch (palya[i, j])
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                        case 8:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case 16:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case 32:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case 64:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case 128:
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            break;
                        case 256:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        case 512:
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            break;
                        case 1024:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                    }
                    Console.Write(palya[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public void Bal()
        {
            int elso;
            for (int i = 0; i < palya.GetLength(0); i++)
            {
                elso = -1;
                for (int j = 0; j <= 3; j++)
                {
                    if ((palya[i, j] == 0) && (elso == -1))
                    {
                        elso = j;
                    }
                    else if ((palya[i, j] != 0) && (elso != -1))
                    {
                        palya[i, elso] = palya[i, j];
                        palya[i, j] = 0;
                        elso--;
                    }

                }
            }
        }
        public void BalRendez()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (palya[i, j] != 0)
                    {
                        if (palya[i, j] == palya[i, j + 1])
                        {
                            palya[i, j] = palya[i, j] + palya[i, j + 1];
                            palya[i, j + 1] = 0;
                        }
                    }
                }
            }
            Bal();
        }
        public void Jobb()
        {
            int elso;
            for (int i = 0; i < palya.GetLength(0); i++)
            {
                elso = -1;
                for (int j = 3; j >= 0; j--)
                {
                    if ((palya[i, j] == 0) && (elso == -1))
                    {
                        elso = j;
                    }
                    else if ((palya[i, j] != 0) && (elso != -1))
                    {
                        palya[i, elso] = palya[i, j];
                        palya[i, j] = 0;
                        elso--;
                    }

                }
            }
        }
        public void JobbRendez()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 3; j > 0; j--)
                {
                    if (palya[i, j] != 0)
                    {
                        if (palya[i, j] == palya[i, j - 1])
                        {
                            palya[i, j] = palya[i, j] + palya[i, j - 1];
                            palya[i, j - 1] = 0;
                        }
                    }
                }
            }
            Jobb();
        }
        public void Le()
        {
            int elso;
            for (int i = 0; i < palya.GetLength(0); i++)
            {
                elso = -1;
                for (int j = 3; j >= 0; j--)
                {
                    if ((palya[j, i] == 0) && (elso == -1))
                    {
                        elso = j;
                    }
                    else if ((palya[j, i] != 0) && (elso != -1))
                    {
                        palya[elso, i] = palya[j, i];
                        palya[j, i] = 0;
                        elso--;
                    }

                }
            }
        }
        public void LeRendez()
        {
            for (int i = 3; i > 0; i--)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (palya[i, j] != 0)
                    {
                        if (palya[i, j] == palya[i - 1, j])
                        {
                            palya[i, j] = palya[i, j] + palya[i - 1, j];
                            palya[i - 1, j] = 0;
                        }
                    }
                }
            }
            Le();
        }
        public void Fel()
        {
            int elso;
            for (int i = 0; i < palya.GetLength(0); i++)
            {
                elso = -1;
                for (int j = 0; j <= 3; j++)
                {
                    if ((palya[j, i] == 0) && (elso == -1))
                    {
                        elso = j;
                    }
                    else if ((palya[j, i] != 0) && (elso != -1))
                    {
                        palya[elso, i] = palya[j, i];
                        palya[j, i] = 0;
                        elso--;
                    }
                }
            }
        }
        public void FelRendez()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (palya[i, j] != 0)
                    {
                        if (palya[i, j] == palya[i + 1, j])
                        {
                            palya[i, j] = palya[i, j] + palya[i + 1, j];
                            palya[i + 1, j] = 0;
                        }
                    }
                }
            }
            Fel();
        }
        public void Mozgas()
        {
            ConsoleKeyInfo _Key = Console.ReadKey();
            switch (_Key.Key)
            {
                case ConsoleKey.RightArrow:
                    Console.WriteLine("Jobb");
                    Jobb();
                    JobbRendez();
                    Addszam();
                    break;
                case ConsoleKey.LeftArrow:
                    Console.WriteLine("Bal");
                    Bal();
                    BalRendez();
                    Addszam();
                    break;
                case ConsoleKey.UpArrow:
                    Console.WriteLine("Fel");
                    Fel();
                    FelRendez();
                    Addszam();
                    break;
                case ConsoleKey.DownArrow:
                    Console.WriteLine("Le");
                    Le();
                    LeRendez();
                    Addszam();
                    break;
                default:
                    break;
            }
        }
        public void Addszam()
        {
            Random rnd = new Random();
            int szam = 0;
            int kilep = 0;
            int i, j;
            do
            {
                i = rnd.Next(0, 4);
                j = rnd.Next(0, 4);
                if (palya[i, j] == 0)
                {
                    palya[i, j] = 2;
                    szam++;
                    //Console.WriteLine("EH");
                }
                else
                {
                    //Console.WriteLine("MEH");
                    kilep++;
                    if (kilep > 20)
                    {
                        break;
                    }
                }
            } while (szam != 1);
        }
        public bool JatekVege()
        {
            for (int i = 0; i < palya.GetLength(0); i++)
            {
                for (int j = 0; j < palya.GetLength(1); j++)
                {
                    try
                    {
                        if (palya[i, j] == 0)
                        {
                            return true;
                        }
                    }
                    catch (System.IndexOutOfRangeException e)
                    {
                        
                    }
                    try
                    {
                        if (palya[i, j] == palya[i, j + 1])
                        {
                            return true;
                        }
                    }
                    catch (System.IndexOutOfRangeException e)
                    {

                    }
                    try
                    {
                        if (palya[i, j] == palya[i, j - 1])
                        {
                            return true;
                        }
                    }
                    catch (System.IndexOutOfRangeException e)
                    {

                    }
                    try
                    {
                        if (palya[i, j] == palya[i + 1, j])
                        {
                            return true;
                        }
                    }
                    catch (System.IndexOutOfRangeException e)
                    {

                    }
                    try
                    {
                        if (palya[i, j] == palya[i - 1, j])
                        {
                            return true;
                        }
                    }
                    catch (System.IndexOutOfRangeException e)
                    {

                    }
                }
            }
            Console.Clear();
            Console.WriteLine("JÁTÉKVÉGE!!!! VESZTETTÉL!");
            return false;
        }
        public bool NyertVagyVesztett()
        {
            if (JatekVege())
            {
                for (int i = 0; i < palya.GetLength(0); i++)
                {
                    for (int j = 0; j < palya.GetLength(1); j++)
                    {
                        if (palya[i, j] == 2048)
                        {
                            Console.Clear();
                            Console.WriteLine("JÁTÉKVÉGE!!!! \n\r Nyertél, gratuálok!");
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
