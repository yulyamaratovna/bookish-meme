// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

Console.Write("Ввведите 1 число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Ввведите 2 число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNumber * secondNumber)
{
    Console.WriteLine("Да, " + firstNumber + " является квадратом от " + secondNumber);
}
else
{
    Console.WriteLine("Нет, " + firstNumber + " не является квадратом от " + secondNumber);
}
