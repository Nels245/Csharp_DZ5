// Задача 34. Задайте массив заполн. случ. числами.
//Найдите сумму элементов на нечетных позициях

Console.Clear();

int [] array = GetArray(4,25,255); //ограничил массив, т.к генерились миллиардные числа)
SumEvenPosition(array);
PrintArray(array, SumEvenPosition(array)); //на вывод массив принимает наш массив и результат return метода CountEven

//Logic --------------------------------------------------------------------------------------------------------------

int[] GetArray(int size, int minValue, int maxValue) //метод заполнения массива
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

int SumEvenPosition(int[] array) //Находим сумму элементов на нечетных позициях
{
    int summ = 0;
    for (int i = 0; i < array.Length; i = i + 2)
        summ += array[i];

    return summ;
}

void PrintArray(int [] array, int summ)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++) //выводим наш массив
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write($"{array[array.Length - 1]}] -> {summ}");

}
