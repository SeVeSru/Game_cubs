using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_cubs
{
    internal class Program
    {
        const int x = 25; //Размер поля
        const int y = 25;
        const string player1Str = "O";//Метка игрока 1
        const string player2Str = "X";//Метка игрока 2
        const string fieldStr = "#";//Метка пустого поля
        static int[,] Pole = new int[x, y];
        static int round = 2;

        static void Main(string[] args)
        {
            Random random = new Random();

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Pole[i, j] = 0;
                }
            }
            //PoleOut();

            
            do
            {
                if (round == 1)
                    round++;
                else round = 1;

                int x = random.Next(1, 7), y = random.Next(1, 7);
                InterfaceMove(round, x, y);
                Console.ReadKey();

            } while (true);
        }
        static void PoleOut()
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                        if (Pole[i, j] == 0)
                            Console.Write(fieldStr);
                        else if (Pole[i, j] == 1)
                            Console.Write(player1Str);
                        else if (Pole[i, j] == 2)
                            Console.Write(player2Str);
                }
                Console.WriteLine();
            }
        }

        static void InterfaceMove(int player, int rx, int ry)
        {
            int x1, y1;
            Console.Clear();

            PoleOut();
            Console.WriteLine("Вам выпало: " + rx + ", и " + ry);

            Console.Write("Выберите позицию: \nx(Вертикально): ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y(Горизантально): ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (player == 1)
                for (int i = x1; i < x1 + rx; i++)
                {
                    for (int j = y1; j < y1 + ry; j++)
                    {
                        Pole[i, j] = player;
                    }
                }
            else if (player == 2)
                for (int i = x1; i < x1 + rx; i++)
                {
                    for (int j = y1; j < y1 + ry; j++)
                    {
                        Pole[x-1-i, y-1-j] = player;
                    }
                }
        }
    }
}
