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
        const string player1Str = "OO";//Метка игрока 1
        const string player2Str = "XX";//Метка игрока 2
        const string fieldStr = "##";//Метка пустого поля
        static int[,] Pole = new int[x, y];

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
            PoleOut();

            Console.ReadKey();
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
    }
}
