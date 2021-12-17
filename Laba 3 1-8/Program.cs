using System;

namespace Laba_3_1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            /*Console.WriteLine("Введите колличество элементов массива:");
            int elements = int.Parse(Console.ReadLine());
            int[] array = new int[elements];
            Random rnd = new Random();
            for (int i = 0; i < elements; i++)
            {
                array[i] = rnd.Next(-31, 46);
                Console.Write("{0} ", array[i]);
                if (i % 10 == 9)
                {
                    Console.WriteLine("\n");
                }
            }
            int[] array2 = new int[1000];

            int j = 0;
            Console.WriteLine("\n Массив в обратном порядке:");

            for (int i = elements - 1; i >= 0; i--)
            {
                array2[j] = array[i];
                
            if (array2[j] < 0)
                {
  
                }
                else
                {
                    Console.Write("{0} ", array2[j]);
                    if (j % 10 == 9)
                    {
                        Console.WriteLine("\n");
                    }
                    j++;
                }
               
            }*/


            //2
            /*Console.WriteLine("Изначальный вид:");
            int[,] array = new int[7, 7];
            Random rnd = new Random();
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    array[i, j] = rnd.Next(0, 10);
                    Console.Write(array[i, j] + " ");

                }
                Console.WriteLine();
            }
            Console.WriteLine("Поворот на 90 градусов направо:");


            for (int j = 0; j < 7; j++)
            {
                for (int i = 7 - 1; i >= 0; i--)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }*/


            //3
            /* Console.WriteLine("Введите колличество элементов массива:");
             int elements = int.Parse(Console.ReadLine());
             int[] array = new int[elements];
             Random rnd = new Random();
             for (int i = 0; i < elements; i++)
             {
                 array[i] = rnd.Next(0, 10);
                 Console.Write("{0} ", array[i]);
             }

             Console.WriteLine("\n На сколько позиций влево будет сдвигаться массив?");
             int k = int.Parse(Console.ReadLine());

             for (int j = 0; j < k; j ++) {
                 int temp = array[0];
                 for (int i = 0; i < array.Length - 1; i++)
                 {
                     array[i] = array[i + 1];
                 }
                 array[array.Length - 1] = temp;
             }
             for (int i = 0; i < array.Length; ++i)
                 Console.Write(array[i] + " ");*/

            //4
            /*Console.WriteLine("Первый массив:");
            double[,] array1 = new double[3, 3];
            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array1[i, j] = rnd.Next(0, 10);
                    Console.Write(array1[i, j] + " ");
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("Второй массив:");
            double[,] array2 = new double[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array2[i, j] = rnd.Next(0, 10);
                    Console.Write(array2[i, j] + " ");

                }
                Console.WriteLine();
            }
            static double[,] sum(double[,] array1, double[,] array2, double average)
            {
                double[,] sum = new double[3, 3];
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        sum[i, j] = array1[i, j] + array2[i, j];
                        average = 0;
                        average = average + sum[i, j];
                    }
                }
                average = average / 9;
                return sum;
            }

            static double[,] diff(double[,] array1, double[,] array2, double average)
            {
                double[,] diff = new double[3, 3];
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        diff[i, j] = array1[i, j] - array2[i, j];
                        average = 0;
                        average = average + array1[i, j] + array2[i, j];
                    }
                }
                average = average / 9;
                return diff;
            }
            double average = 0;
            int line = 0;
            Console.WriteLine("Сумма Массивов:");
            foreach (double element in sum(array1,array2, average))
            {
                if (line % 3 == 0)
                {
                    Console.Write("\n");
                    Console.Write($"{element,4}");
                }
                else
                {
                    Console.Write($"{element,4}");
                }
                line ++;
            }

            Console.WriteLine("\nРазность Массивов:");
            foreach (double element in diff(array1, array2, average))
            {
                if (line % 3 == 0)
                {
                    Console.Write("\n");
                    Console.Write($"{element,4}");
                }
                else
                {
                    Console.Write($"{element,4}");
                }
                line++;
            }*/


            /*//5
            Console.WriteLine("Первый массив:");
            double[,] array1 = new double[5, 5];
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array1[i, j] = rnd.Next(0, 10);
                    Console.Write(array1[i, j] + " ");
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("Второй массив:");
            double[,] array2 = new double[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array2[i, j] = rnd.Next(0, 10);
                    Console.Write(array2[i, j] + " ");

                }
                Console.WriteLine();
            }

            static double[,] product(double[,] array1, double[,] array2)
            {
                double[,] product = new double[5, 5];
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        product[i, j] = array1[i, j] * array2[i, j];
                    }
                }
                return product;
            }
            Console.WriteLine("\n Произведение массивов:");
            int line = 0;
            foreach (double element in product(array1, array2))
            {
                if (line % 5 == 0)
                {
                    Console.Write("\n");
                    Console.Write($"{element,4}");
                }
                else
                {
                    Console.Write($"{element,4}");
                }
                line++;
            }*/


            //6
            /*Console.WriteLine("Введите колличество элементов массива:");
            int elements = int.Parse(Console.ReadLine());
            double[] array = new double[elements];
            Random rnd = new Random();
            for (int i = 0; i < elements; i++)
            {
                array[i] = rnd.Next(0, 10);
                Console.Write("{0} ", array[i]);
            }
            static double sumIterative(double[] array)
            {
                double sum = 0;
                for (int i = 0; i < array.Length; i++) 
                { 
                sum = sum + array[i];
                }
                    return sum;
            }
            Console.WriteLine("Сумма элементво(Итерационно):" + sumIterative(array));


            static double sumRecursive(double[] array, int i = 0)
            {
                if (i >= array.Length)
                {
                    return 0;
                }
                else
                {
                    return array[i] + sumRecursive(array, i + 1);
                }
            }
            Console.WriteLine("Сумма элементво(Рекурсивно):" + sumRecursive(array));


            static double minIterative(double[] array)
            {
                double min = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                    }
                }
                return min;
            }
            Console.WriteLine("Минимальный элемент в массиве(Итерационно):" + minIterative(array));

            static double minRecursive(double[] array, int i = 0)
            {
                if (i + 1 == array.Length)
                {
                    return array[i];
                }
                else
                {
                    return Math.Min(array[i], minRecursive(array, ++i));
                }

            }
            Console.WriteLine("Минимальный элемент в массиве(Рекурсивно):" + minRecursive(array));*/


            //7
            /*Console.WriteLine("Введите номер(n) элемента, которое вы хотите найти в ряде Фибоначчи");
            int element = int.Parse(Console.ReadLine());
            if ( element < 1)
            {
                Console.WriteLine("Номер не может быть отрицателен или равен нулю, введите число, \n которое будет удовлетворять этому условию: element > 1");
                element = int.Parse(Console.ReadLine());
            }

            int row(int n)
            {
                if (n == 0 || n == 1)
                {
                    return n;
                } else { 
                return row(n - 1) + row(n - 2);
                }
            }
            Console.WriteLine(element + " элемент в ряде Фибоначчи - " + row(element-1));*/

            //8
            /*Console.WriteLine("Введите длину массива N*N (ввести N):");
            int N = int.Parse(Console.ReadLine());
            double[,] array = new double[N, N];
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i, j] = rand.Next(0, 10);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            static double DetMatrix(double[,] array)
            {
                if (array.Length == 1)
                    return array[0, 0];

                if (array.Length == 4)
                    return array[0, 0] * array[1, 1] - array[1, 0] * array[0, 1];

                else
                {
                    double result = 0;

                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        double[,] M = Minor(array, i); //вычисление минора М
                        result += Math.Pow(-1, i) * array[0, i] * DetMatrix(M);
                    }
                    return result;
                }

            }

            static double[,] Minor(double[,] array, int n)
            {
                double[,] result = new double[array.GetLength(0) - 1, array.GetLength(0) - 1];
                for (int i = 1; i < array.GetLength(0); i++)
                {
                    for (int j = 0, column = 0; j < array.GetLength(1); j++)
                    {
                        if (j == n)
                            continue;
                        result[i - 1, column] = array[i, j];
                        column++;
                    }
                }
                return result;
            }

            Console.WriteLine("Определитель матрицы: " + DetMatrix(array));*/


            //Индивидуальное задание №1
            int N = 7;
            double[,] array = new double[N, N];
            Random rand = new Random();
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    array[i, j] = rand.Next(0, 10);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                    Console.Write(array[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int j = 0; j < N; j++)
            {
                for (int i = N - 1; i >= 0; i--)

                    Console.Write(array[i, j] + " ");
                Console.WriteLine();
            }

        }
    }
}
