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

        static void Main(string[] args)
        {
            int[,] Pole = new int[x, y];
            Random random = new Random();

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Pole[i, j] = 0;
                }
            }

            Console.ReadKey();
        }
    }
}
