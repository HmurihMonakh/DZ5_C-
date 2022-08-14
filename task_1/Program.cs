
//Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

void PrintArray(int[] col)
    {
        int count = col.Length;
        int position = 0;
        while (position < count)
            {
                Console.Write($"{col[position]} ");
                position++;
            }
    }
Console.WriteLine("введите размер массива");
int numbers = Convert.ToInt32(Console.ReadLine());
int[] massive = new int[numbers];

for(int i = 0; i < massive.Length; i++)
    {
        massive[i] = new Random().Next(100,1000);
    }

PrintArray(massive);
Console.WriteLine();
//Задали массив заполненный случайными положительными трёхзначными числами
int count = 0;
for (int j = 0; j < massive.Length; j++)
{
    if (massive[j] % 2 == 0)
    count++;
}

Console.WriteLine($"всего {massive.Length} чисел, {count} из них чётные");












