using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_13
{
    public class Program
    {


        public static void Main()
        {
            int max = 0; // объявление переменной

            // задаем матрицу
            int[,] q = new int[4, 4]; //инициализируем массив
            Random rnd = new Random(); //заполняем матрицу случайными числами
            for (int i = 0; i < 4; i++) // цикл, пока верно условие
            {
                for (int j = 0; j < 4; j++)
                {
                    q[i, j] = rnd.Next(-10, 10);
                    Console.Write(q[i, j] + "\t"); // вывод на экран
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++) // цикл, пока верно условие
            {
                for (int j = 0; j < 4; j++) // цикл, пока верно условие
                {
                    if (q[i, j] > max) max = q[i, j]; // находим наибольший элемент

                }
            }
            for (int i = 0; i < 4; i++) // цикл, пока верно условие
            {
                for (int j = 0; j < 4; j++) // цикл, пока верно условие
                {
                    if (q[i, j] == max) q[i, j] = max; // находим наибольший элемент
                }
            }
            Console.WriteLine("максимальный элемент: " + max); // вывод на экран
            Console.WriteLine("строка, ктоторая содержит наибольшее число: "); //// вывод на экран


            for (int i = 0; i < 4; i++) // цикл, пока верно условие
            {
                for (int j = 0; j < 4; j++)
                {

                    Console.Write(q[i, j] + "\t"); // вывод на экран
                }
                Console.WriteLine();
                Console.ReadKey(); //программа ждет нажатия клавиши для завршения работы

            }
        }
    }
}