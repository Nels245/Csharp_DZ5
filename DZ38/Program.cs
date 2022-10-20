// Задача 38. Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементом массива

Console.Clear();

int [] array = GetArray(4,1,111); //не смог сделать с double, вылезала ошибка 
//error CS0266: Не удается неявно преобразовать тип "double" в "int". Существует явное преобразование (возможно, 
//пропущено приведение типов)

DiffMaxMin(array);
PrintArray(array, DiffMaxMin(array));

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

int DiffMaxMin(int[] array) //Находим разницу мин и макс элемента
{
    int min = array[0];
    int max = array[0];
    int diff = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        if (min > array[i])
            min = array[i];
    }
    diff = max - min;


    return diff;
}

void PrintArray(int [] array, int diff)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++) //выводим наш массив
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write($"{array[array.Length - 1]}] -> {diff}");

}