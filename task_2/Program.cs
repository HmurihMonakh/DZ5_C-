//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0


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
int sum = 0;
for(int j = 0; j <massive.Length; j+=2 )
{
    sum = sum + massive[j];
}
Console.WriteLine($"всего {massive.Length} чисел, сумма на четных позициях = {sum}" );






