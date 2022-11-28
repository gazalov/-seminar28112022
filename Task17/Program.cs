Console.Clear();
int DataEntryXY(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void FindQuadrant(int x, int y)
{
    if((x>0) && (y>0)) Console.WriteLine("Это первый квадрант.");
    if((x<0) && (y>0)) Console.WriteLine("Это второй квадрант.");
    if((x<0) && (y<0)) Console.WriteLine("Это третий квадрант.");
    if((x>0) && (y<0)) Console.WriteLine("Это четвертый квадрант.");
}

int x = DataEntryXY("Введите координаты x = ");
//Console.WriteLine(x);
int y = DataEntryXY("Введите координаты y = ");
//Console.WriteLine(y);

FindQuadrant(x, y);
