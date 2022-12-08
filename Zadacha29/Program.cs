// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] mass = new int[8];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(0,9);

    Console.Write(" " + mass[i]);
}