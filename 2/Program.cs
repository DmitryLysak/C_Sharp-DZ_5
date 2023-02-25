//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = randomArray(4); 
Console.WriteLine($"[{string.Join(",",array)}] -> {sumOfOdd(array)}"); 

 int[] randomArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++){
        result[i] = new Random().Next(100);
    }
    return result;
}

int sumOfOdd(int[] array) 
{ 
 int sum = 0; 
 for(int i = 0; i < array.Length; i++) { 
 if(i % 2 != 0) { 
 sum += array[i]; 
        }
    }
 return sum; 
}
