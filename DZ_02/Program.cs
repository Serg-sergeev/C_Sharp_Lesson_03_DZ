// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int GetSquareNumber(int a)
{
    return a * a;
}

int GetSumSquareCoordinate3D(int[] arrCoordA, int[] arrCoordB)
{
    int coordX = GetSquareNumber(arrCoordA[0] - arrCoordB[0]);
    int coordY = GetSquareNumber(arrCoordA[1] - arrCoordB[1]);
    int coordZ = GetSquareNumber(arrCoordA[2] - arrCoordB[2]);

    return coordX + coordY + coordZ;
}

void PrintDistanceAB(int[] corA, int[] corB)
{
    Console.Write("Расстояние между точками A и B - ");
    Console.WriteLine(Math.Sqrt(GetSumSquareCoordinate3D(corA, corB)));
}

int[] GetArrayStringToInt(string[] array)
{
    int index = 0;
    int[] arrayInt = new int[array.Length];
    while (index < array.Length)
    {
        arrayInt[index] = int.Parse(array[index]);
        index++;
    }
    return arrayInt;
}

Console.Write("Введите координаты точки A в формате x y z - ");
string[] xyzA = Console.ReadLine()!.Split(' ').ToArray();
Console.Write("Введите координаты точки B в формате x y z - ");
string[] xyzB = Console.ReadLine()!.Split(' ').ToArray();

int[] xyzAToInt = GetArrayStringToInt(xyzA);
int[] xyzBToInt = GetArrayStringToInt(xyzB);

PrintDistanceAB(xyzAToInt, xyzBToInt);