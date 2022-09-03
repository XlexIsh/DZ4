// Задача 27: Напишите программу, которая принимает на вход число
//  и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число A");
bool isNumberA = int.TryParse(Console.ReadLine(), out int A);

if (isNumberA != true )
{
     Console.WriteLine("Число введено не верно.");
    return;
}

 int GetSum(int A)
 {
     int result = 0;
     int number;
     while (A > 0)
     {
         number = A % 10;
         result = result + number;
         A = A / 10;
     }
     return result;
 }
Console.WriteLine(GetSum(A));

