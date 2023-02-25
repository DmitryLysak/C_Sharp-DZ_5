// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76

int[] array = RandomArray(4, 0, 100);
Console.WriteLine($"[{String.Join(" ", array)}]");
Console.WriteLine($"Разница-> {Diff(array)}");

int[] RandomArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
int Diff(int[] array)
{
    int min = array[0];
    int max = array[0];
    
    foreach (int j in array)
    {
        if (min > j) min = j;
        if (max < j) max = j;
    }
    Console.WriteLine($"Минимальный элемент -> {max}");
    Console.WriteLine($"Максимальный элемент -> {min}");
    return max - min;
}