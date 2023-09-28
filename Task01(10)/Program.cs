// Ввод - трёхзначное число
// Вывод - десяток этого числа 

int n;
Vvod:
Console.Write("введите трёхзначное число: ");
while (!int.TryParse(Console.ReadLine(), out n))
    Console.Write("введите трёхзначное число: ");

int VivodDes(int x)
{
    x = (x / 10) % 10;
    return x;
}

if (n > 99 && n < 1000)
{
    int result = VivodDes(n);
    Console.WriteLine($"{n} -> {result}");
}
else
{
    goto Vvod;
}

