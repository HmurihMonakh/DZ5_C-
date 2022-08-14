//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76



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
        massive[i] = new Random().Next(1,100);
    }

PrintArray(massive);
Console.WriteLine();

int max = massive[0];
int min = massive[0];
for(int i = 0; i < numbers; i++)
{
    if(massive[i] > max)
    {
        max = massive[i];
    }
    if(massive[i] < min)
    {
        min = massive[i];
    }

}
Console.WriteLine("Разница между максимальным и минимальным элементом масива = {0}", max - min);



