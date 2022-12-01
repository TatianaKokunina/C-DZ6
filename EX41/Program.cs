/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

int [] GenerateUserNumbers (int length, int start, int end)
{
    Console.Write("Введите количество чисел (M): ");
    length = int.Parse(Console.ReadLine());
    int [] array = new int [length];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        array[i] = int.Parse(Console.ReadLine());                    
    }
    return array;
}
void PrintArray(int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int FindPositiveNumbers (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
int [] newArray = GenerateUserNumbers(10,-100, 100);
Console.WriteLine();
PrintArray(newArray);
int countPositiveNumbers = FindPositiveNumbers(newArray);
Console.WriteLine();
Console.WriteLine ($"Количество положительных чисел = {countPositiveNumbers}");