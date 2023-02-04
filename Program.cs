/* int GetQuadrant(int x, int y)
{
    int quadNum = 0;
    if (x > 0 && y > 0) quadNum = 1;
    else if(x < 0 && y > 0) quadNum = 2;
    else if(x < 0 && y < 0) quadNum = 3;
    else if(x > 0 && y < 0) quadNum = 4;
    return quadNum; 
}
*/

//задача 1
/* void PrintQuadrant(int quadNum)
{
    if(quadNum == 1)
        Console.WriteLine("x > 0, y > 0");
    else if(quadNum == 2)
        Console.WriteLine("x < 0, y > 0");
    else if(quadNum == 3)
        Console.WriteLine("x < 0, y < 0");
    else if(quadNum == 4)
        Console.WriteLine("x > 0, y < 0");
    else
        Console.WriteLine("Неверный номер четверти!");
}

Console.Write("введите номер четверти (1..4): ");
PrintQuadrant(Convert.ToInt32(Console.ReadLine()));
*/
//задача 2
/* void PrintSquares(int n)
{
    for(int i = 1; i <= n; i++)
    {
        Console.Write(i * i + " ");
    }
}
Console.Write("введите число N: ");
PrintSquares(Convert.ToInt32(Console.ReadLine()));
*/
//задача 3

double LineLength(double x1, double y1, double x2, double y2)
{
    double line1Length, line2Length, result;
    line1Length = x2 - x1;
    line2Length = y2 - y1;
    result = Math.Sqrt(Math.Pow(line1Length, 2) + Math.Pow(line2Length, 2));
    return result;
    // return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}

Console.Write("Введите координату Х первой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Х второй точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Длина отрезка: " + Math.Round(LineLength(x1, y1, x2, y2), 2));
