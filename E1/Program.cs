// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4


Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

int schet = 0;

int[] array = GetArray(size);
Console.WriteLine($"Исходный массив: [{String.Join(", ", array)}]");

foreach(int chislo in array)
{
    schet += chislo > 0 ? 1 : 0;
}

Console.WriteLine($"Количество положительных элементов в массиве = { schet}");

// Функция заполнения массива
int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите элемент массива № { i } : ");
        result[i] = int.Parse(Console.ReadLine()!); 
    }
    return result;
}