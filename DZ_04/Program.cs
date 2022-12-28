//Напишите программу, которая принимает на вход число (N) и выдает таблицу простых чисел от 1 до N.

int[] GetArrayOneToNumber(int number)
{
    int index = 0;
    int[] arr = new int[number];

    while (index < number)
    {
        arr[index] = GetCubeNumber(index + 1);
        index++;
    }
    return arr;
}

int[] GetArrayIntegerNumbers(int[] arr)
{
    int[] arrInteger = new int[arr.Length];
    int index = 1;
    int count = arr.Length;
    arrInteger[0] = 1;

    while (index < count)
    {
        if ((arr[index] / arr[index]) == 1)
        {
            return arr; //Дописать!!!
        }
    }

}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
