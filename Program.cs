// Задача 3
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void PrintCubeTable(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                int cube = i * i * i;
                Console.Write(cube + " ");
            }
        }

        Console.Write("Введите число N: ");
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine("Таблица кубов чисел от 1 до " + N + ":");
        PrintCubeTable(N);
