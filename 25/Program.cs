// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A");
bool isNumberA = int.TryParse(Console.ReadLine(), out int A);

if (isNumberA != true )
{
     Console.WriteLine("Число введено не верно.");
    return;
}

Console.WriteLine("Введите число B");
bool isNumberB = int.TryParse(Console.ReadLine(), out int B);

if (isNumberB != true )
{
     Console.WriteLine("Число введено не верно.");
    return;
}
int results = 1;
for (int i = 0; i < B; i++)
{
    results = results * A;
}
Console.WriteLine("Результат вычисления А в степени В равен:");
Console.WriteLine(results);