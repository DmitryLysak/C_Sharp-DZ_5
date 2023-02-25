//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = randomArray(4); 
Console.WriteLine($"[{string.Join(", ",array)}] -> {sumOfEvenNumbers(array)}"); 

 int[] randomArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++){
        result[i] = new Random().Next(1000);
    }
    return result;
}
int sumOfEvenNumbers(int[] array) 
{ 
 int sum = 0; 
 for(int i = 0; i < array.Length; i++) { 
 if(array[i] % 2 == 0) 
{
 sum = sum+1; 
}    
    }
return sum;
}

