Console.Clear();

int DataEntryXY(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void Distance(int x1, int y1, int x2, int y2)
{
    double dist = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
    Console.WriteLine(dist);
}


int x1 = DataEntryXY("Введите координаты x1 = ");
int y1 = DataEntryXY("Введите координаты y1 = ");

int x2 = DataEntryXY("Введите координаты x1 = ");
int y2 = DataEntryXY("Введите координаты y1 = ");

Distance(x1, y1, x2, y2);
