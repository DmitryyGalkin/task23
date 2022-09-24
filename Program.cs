Console.Clear();

Console.WriteLine("введите число: ");
int num = int.Parse(Console.ReadLine()!);
int count = 0;
for (count = 1; count <= num; count++)
{
    Console.Write(Math.Pow(count, 3));
    if (count != num)
    {
        Console.Write(", ");
    }
}