//Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

int Prompt(string num)
{
    System.Console.Write (num);

    return int.Parse(Console.ReadLine());
}

void FuncLines (double b1, double b2, double k1, double k2 )
{
    double x = (b2-b1)/(k1-k2);
    double y = (k2 * x )+ b2;
    Console.Write($"Координаты пересечения двух прямых ==> [{x};{y}]");
    ///return (0);
}
double k1 = Prompt("Введите значениe  k1 - > ");
double b1 = Prompt("Введите значениe  b1  - > ");

double k2= Prompt("Введите значениe  k2 - > ");
double b2 = Prompt("Введите значениe  b2 - > ");
FuncLines (b1, b2, k1,k2 );