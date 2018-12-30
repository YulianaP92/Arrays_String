using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Base.Lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //B6_P1_6_1DReadConsoleMassive();
            //B6_P2_6_3DMassiveMaxInRow();
            //B6_P3_6_1DMasiveSort();
            //Pyatnashki();
            //PoemGeneration();
            //B6_P5_6_CutString();
            //B6_P6_6_ReplaceInPoem();
            Console.ReadLine();
        }

        public static void B6_P1_6_1DReadConsoleMassive()
        {
            int[] mas = new int[6];
            Console.WriteLine("Заполните массив 6-ю цифрами:");
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Массив после заполнения: ");
            foreach (var i in mas)
            {
                Console.Write($"{i}\t");
            }
        }

        public static void B6_P2_6_3DMassiveMaxInRow()
        {
            var max = 0;
            Random r = new Random();
            int[,] mas_2 = new int[3, 4];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    mas_2[i, j] = r.Next(100);
                    Console.Write(mas_2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < mas_2.GetLength(0); i++)
            {
                max = 0;
                for (int j = 0; j < mas_2.GetLength(1); j++)
                {

                    if (mas_2[i, j] > max)
                    {
                        max = mas_2[i, j];
                    }
                }
                Console.WriteLine($"Максимальный элемент в {i} строке: {max}");
            }
        }

        public static void B6_P3_6_1DMasiveSort()
        {
            int[] mas = new int[5];
            Random numbers = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = numbers.Next(20);
            }
            Console.WriteLine("Массив до сортировки: ");
            foreach (var i in mas)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("Массив после сортировки: ");
            mas = Sort(mas);
            foreach (var i in mas)
            {
                Console.Write(i + "\t");
            }
        }

        public static int[] Sort(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length - 1; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }
        public static void PoemGeneration()
        {
            Random r = new Random();
            char[][] poem = new char[100][];
            for (int i = 0; i < poem.Length; i++)
            {
                var word = new char[r.Next(10)];
                for (int j = 0; j < word.Length; j++)
                {
                    word[j] = (char)r.Next(1040 - 1, 1103 - 1);
                }
                poem[i] = word;
            }
            foreach (var i in poem)
            {
                Console.Write(i);
            }
        }

        public static void Pyatnashki()
        {

            var numbers = new[,] { { 0, 8, 14, 3 }, { 10, 6, 1, 13 }, { 11, 12, 15, 4 }, { 7, 5, 2, 9 } };
            PrintValues(numbers);
            Play(numbers);
        }

        private static void PrintValues(int[,] numbers)
        {
            int rows = numbers.GetLength(0);
            int columns = numbers.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{numbers[i, j]}\t");

                }
                Console.WriteLine();
            }
        }

        private static void Play(int[,] numbers)
        {
            var zeroI = 0;
            var zeroJ = 0;
            for (int numb = 0; numb <= 5; numb++)
            {
                var movement = Console.ReadKey().KeyChar;
                var i = zeroI;
                var j = zeroJ;
                if (movement == 'a' || movement == 'A')
                {
                    if (j > 0)
                        j--;
                    else
                    {
                        Console.WriteLine("Операция невозможна!");
                        continue;
                    }
                }

                else if (movement == 's' || movement == 'S')
                {
                    if (i < 4)
                        i++;
                    else
                    {
                        Console.WriteLine("Операция невозможна!");
                        continue;
                    }
                }

                else if (movement == 'd' || movement == 'D')
                {
                    if (j < 4)
                        j++;
                    else
                    {
                        Console.WriteLine("Операция невозможна!");
                        continue;
                    }
                }

                else if (movement == 'w' || movement == 'W')
                {
                    if (i > 0)
                        i--;
                    else
                    {
                        Console.WriteLine("Операция невозможна!");
                        continue;
                    }
                }

                else
                    Console.WriteLine("Введите соответствующую клавишу");
                var swap = numbers[i, j];
                numbers[i, j] = numbers[zeroI, zeroJ];
                numbers[zeroI, zeroJ] = swap;

                zeroI = i;
                zeroJ = j;

                PrintValues(numbers);
            }
        }

        public static void B6_P5_6_CutString()
        {
            Console.WriteLine("Введите строку: ");
            string row = Console.ReadLine();
            int numberOfSymbols = 0;
            const int count = 13;
            foreach (var i in row)
            {
                numberOfSymbols++;
            }
            if (numberOfSymbols > count)
            {
                row = row.Substring(0, count);
                row = String.Concat(row, "...");
            }
            Console.WriteLine($"Новая строка:\n{row}");
        }

        public static void B6_P6_6_ReplaceInPoem()
        {
            string w_1 = "Старость";
            string w_2 = "не";
            string w_3 = "радость";
            string w_4 = "молодость";
            string w_5 = "гадость";
            string[] words = new[] { w_1, w_2, w_3, w_4, w_5 };
            string newWord = String.Join(";", words);
            Console.WriteLine(newWord);

            string[] words_2 = newWord.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words_2.Length; i++)
            {
                words_2[i] = words_2[i].Replace('о', 'a');
                words_2[i] = words_2[i].Replace("л", "ль");
                words_2[i] = words_2[i].Replace("ть", "т");
                Console.WriteLine(words_2[i]);
            }
        }
    }
}


