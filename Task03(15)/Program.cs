int dayNum;
Nedela:
Console.Write("Введите целое число");
while (!int.TryParse(Console.ReadLine(), out dayNum))
    Console.Write("Введите целое число от 1 до 7");

bool Vihodnie(int v)
{
    if (v > 5)
    {
        return true;
    }
    return false;
}

bool Budni(int b)
{
    if (b < 6 && b > 0)
    {
        return true;
    }
    return false;
}

if (Vihodnie(dayNum))
{
    Console.Write($"{dayNum} -> да");
}
else if (Budni(dayNum))
{
    Console.Write($"{dayNum} -> нет");
}
else
{
    Console.WriteLine("Введите число от 1 до 7");
    goto Nedela;
}