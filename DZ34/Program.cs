// Задача 34. Задайте массив заполн. случ. числами +, трёхзнач.)
// кол-во чётных чисел в массиве

Console.Clear();

int [] array = GetArray(5, 100, 1000);
CountEven(array);
PrintArray(array, CountEven(array)); //на вывод массив принимает наш массив и результат return метода CountEven

//Logic --------------------------------------------------------------------------------------------------------------

int[] GetArray(int size, int minValue, int maxValue) //метод заполнения массива
{
    int[] res = new int[size];// задаем размер массива

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

int CountEven(int[] array) //считем кол-во четных чисел в массиве
{
    int count = 0;
    foreach (int el in array)
        if (el % 2 == 0) count +=1;

    return count;
}

void PrintArray(int [] array, int count)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++) //выводим наш массив
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write($"{array[array.Length - 1]}] -> {count}");

}

