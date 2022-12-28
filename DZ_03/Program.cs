//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int GetCubeNumber(int number)
{
    return number * number * number;
}

int GetDischangeOfTable(int number)
{
    int index = 3;
    int discharge;
    while (true)
    {
        if (number > (index * index))
        {
            discharge = index;
            index++;
        }
        else 
        {
            return discharge = index;
        }
    }
}

int[] GetArrayCubes(int number)
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

void PrintTablsCubes(int number)
{
    int[] arrayCubes = GetArrayCubes(number);
    int discharge = GetDischangeOfTable(number);
    Console.WriteLine($"Разряд: {discharge}");

    Console.WriteLine($"Таблицы кубов от 1 до {number}: ");

    int count = 1;
    int index = 0;

    while (index < number)
    {
        if (count < discharge)
        {
            Console.Write(arrayCubes[index] + " ");
            count++;
        }
        else 
        {
            Console.WriteLine(arrayCubes[index]);
            count = 1;
        }
        index++;
    }

}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
PrintTablsCubes(number);