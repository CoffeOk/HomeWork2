// Ввод - заданное число
// Вывод - третья цифра заданного числа, если третьей цифры нет возвращает соответствующее сообщение


int n, result;
Console.Write ("введите целое число: ");
while (!int.TryParse (Console.ReadLine(), out n))
    Console.Write ("введите целое число: ");

int TriPoz (int num)
{
    while (num > 999)
    {
        num /= 10;
    } 
    return num % 10;
}
if (n > 99)
{
    result = TriPoz (n);
    Console.Write ($"{n} -> {result}");
}
else 
{
    Console.Write ($"{n} -> третьей цифры нет");
} 
