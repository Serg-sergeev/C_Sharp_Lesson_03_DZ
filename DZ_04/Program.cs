//Напишите программу, которая принимает на вход число (N) и выдает таблицу простых чисел от 1 до N.

int[] GetArrayOneToNumber(int number)
{
    int index = 0;
    int[] arr = new int[number];

    while (index < number)
    {
        arr[index] = index + 1;
        index++;
    }
    return arr;
}

int[] GetArrayIntegerNumbers(int[] arr)
{
    int index = 1;
    int[] arrInteger = new int[1];
    int count = arr.Length;
    arrInteger[0] = 1;

    while (index < count)
    {
        if (CheckingDivisionOnPrimeNumbers(arr[index]))
        {
            Array.Resize(ref arrInteger, arrInteger.Length + 1);
            arrInteger[arrInteger.Length - 1] = arr[index];
        }
        index++;
    }

    return arrInteger;

    bool CheckingDivisionOnPrimeNumbers(int number)
    {
        int index = 2;
        while (index < number)
        {
            if ((number % index) == 0)
            {
                return false;
            }
            index++;
        }

        return true;
    }

}

void PrintArray(int[] arr)
{
    int index = 0;
    int number = arr.Length;
    while (index < number)
    {
        if (index == number - 1)
        {
            Console.Write(arr[index]);   
        }
        else 
        {
            Console.Write(arr[index] + ", ");
        }
        index++;
    }
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

PrintArray(GetArrayIntegerNumbers(GetArrayOneToNumber(number)));