// Задача 12: Удалить вторую цифру трёхзначного числа.

int GetLastDigit(int number)
{
    int result = number % 10;
    return result;
}

int number = new Random().Next(100,1000);
int thirdDigit = GetLastDigit(number);
int firstDigit = number / 100;
int result = firstDigit*10 + thirdDigit;
Console.WriteLine($"Трехзначное число - {number}, итоговое число - {result}");
