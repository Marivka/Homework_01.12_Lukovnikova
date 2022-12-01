// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0 


// P.S.: Есть какая-то ошибка, программа не всегда считает верно, но я не могу понять какая. =(


var array = FillArray(4);
Print(array);
Console.WriteLine();
Console.Write($"Сумма элементов, стоящих на нечетных позициях {OddIndex(array)}");


int OddIndex(int[] array)
{
    int odd = 0;
    for(int i= 0; i < array.Length; i++)
        {
           if (array[i] % 2 == 1)
           if (i % 2 == 1)
           odd += array[i];
        }
    return odd;
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1, 6);
    }
    return array;
}

void Print(int[] array)
{
    foreach(var item in array)
    {
        Console.Write($"{item}, ");
    }
}