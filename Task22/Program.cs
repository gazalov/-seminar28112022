/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4 */
Console.Clear();
int DataEntryXY(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void Calc(int num)
{
    int inter = 1;
    while (inter <= num)
    {
        Console.WriteLine(inter * inter);
        inter++;
    }

}
int x = DataEntryXY("Введите N: ");
Calc(x);
