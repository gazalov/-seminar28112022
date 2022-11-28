/*Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).*/

Console.Clear();
int DataQuadrant(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void Otvet(int quadrant)
{
    if(quadrant == 1) Console.WriteLine("X больше нуля, Y больше нуля.");
    if(quadrant == 2) Console.WriteLine("X меньше нуля, Y больше нуля.");
    if(quadrant == 3) Console.WriteLine("X меньше нуля, Y меньше нуля.");
    if(quadrant == 4) Console.WriteLine("X больше нуля, Y меньше нуля.");
}

int quadrant = DataQuadrant("Введите квадрант: ");

Otvet(quadrant);