// Задача 14: Найти третью цифру числа или сообщить, что её нет.

int InputNubmer() //метод "Эвод числа с клавиатуры"
{
    int result = 0;
    bool isError = true;
    while (isError)
    {
        Console.Write("Введите целое число: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out result)) isError = false;
    }
    return result;
}

int NumberOfDigits(int number) //метод "Вычисление количества цифр в числе"
{ 
    int result = number / 1000;
    int ten = 1000;
    int digits = 3;
    while (Math.Abs(result) > 0)
    {
        digits++;
        ten = ten * 10;
        result = number / ten; 
    }
    return digits;
}

int LastDigit(int number) //метод "Определение последней цифры"
{
    int result = Math.Abs(number) % 10;
    return result;
}

int number = InputNubmer();
if (Math.Abs(number) < 100) Console.WriteLine("В числе нет третьей цифры");
else 
{
    int result = 0;
    int digits = NumberOfDigits(number);
    int count = digits - 2;
    int numberA = number;
    for (int i = 0; i < count; i++)
    {
        result = LastDigit(numberA);
        numberA = numberA / 10;
    }
    Console.WriteLine($"В числе {number} третья цифра - {result}");
};

