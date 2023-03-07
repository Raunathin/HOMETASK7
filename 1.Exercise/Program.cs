/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 
ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Clear();

System.Console.Write($"Введите количество элементов: ");

int ElementsCount = int.Parse(Console.ReadLine());

int[] MyArray = new int[ElementsCount];

for (int i = 0; i < MyArray.Length; i++)
{
    System.Console.Write($"Введите элемент массива под индексом {i}: ");
    MyArray[i] = int.Parse(Console.ReadLine());
}

int CountAllPositiveNumbers(int[] InputArray)
{
    int count = 0;
    for (int i = 0; i < InputArray.Length; i++)
    {
        if (InputArray[i] > 0)
        {
            count++;
        }
    }
    return count;
}
System.Console.Write($"Цифр больше нуля:{CountAllPositiveNumbers(MyArray)}");


