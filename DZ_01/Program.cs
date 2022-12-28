// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
void PrintResult(int result)
{
    if (result == 1)
        {
            Console.WriteLine("Введеное число является палиндромом");
        }
        else if (result == -1)
        {
            Console.WriteLine("Введеное число НЕ является палиндромом");
        }
        else
        {
            Console.WriteLine("Код ошибки 0х00");
        }
}

void ExaminationPalindrome (int[] array)
{
    int index = 0;
    int count = array.Length;
    int result = 0;

    if (count % 2 == 0)
    {
       while(index <= (count / 2))
        {
            if (array[index] == array[count - 1 - index])
            {
                result = 1;
                index++;
            }
            else 
            {
                result = -1;
                break;
            }
        }

        // Этот блок кода вынесен/описан в методе PrintResult
        // if (result == 1)
        // {
        //     Console.WriteLine("Введеное число является палиндромом");
        // }
        // else if (result == -1)
        // {
        //     Console.WriteLine("Введеное число НЕ является палиндромом");
        // }
        // else
        // {
        //     Console.WriteLine("Код ошибки 0х00");
        // }

        PrintResult(result);

    }

    if (count % 2 == 1)
    {
       while(index < (count / 2))
        {
            if (array[index] == array[count - 1 - index])
            {
                result = 1;
                index++;
            }
            else 
            {
                result = -1;
                break;
            }
        }

        // Этот блок кода вынесен/описан в методе PrintResult
        // if (result == 1)
        // {
        //     Console.WriteLine("Введеное число является палиндромом");
        // }
        // else if (result == -1)
        // {
        //     Console.WriteLine("Введеное число НЕ является палиндромом");
        // }
        // else
        // {
        //     Console.WriteLine("Код ошибки 0х00");
        // }

        PrintResult(result);

    }
    
}

int[] NumberTranslationArray(int number)
{
    //int index = 0;
    int[] array = new int[0];
    int remainderOfDivision;

    while(number != 0)
    {
        remainderOfDivision = number % 10;

//        Console.Write("Остаток от деления: "); // для тестирования
//        Console.WriteLine(remainderOfDivision); // для тестирования

        Array.Resize(ref array, array.Length + 1);
        array[array.Length -1] = remainderOfDivision;

//        Console.Write("Длина массива: "); // для тестирования
//        Console.WriteLine(array.Length); // для тестирования

        number = number / 10;

//        Console.Write("Результат деления на 10: "); // для тестирования
//        Console.WriteLine(number); // для тестирования
    }

    return array;
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

ExaminationPalindrome(NumberTranslationArray(number));