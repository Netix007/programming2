// Задача 16: Дано число обозначающее день недели. Выяснить является номер дня недели выходным.

int number = new Random().Next(1,8);
if (number == 6 || number == 7)
{
    Console.WriteLine($"{number}-ой день недели - выходной день");
}
else
{
    Console.WriteLine($"{number} - рабочий день");
}
