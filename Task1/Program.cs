// Задача 10: Показать вторую цифру трёхзначного числа.

int GetLastDigit(int number)
{
    int result = number % 10;
    return result;
} 

int number = new Random().Next(100,1000);
int result = number / 10;
result = GetLastDigit(result);
Console.WriteLine($"Вторая цифра числа {number} - {result}");
