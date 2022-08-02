// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8 -> 30

int Prompt(string message)
{
  Console.WriteLine(message);
  string a_String = Console.ReadLine();
  return int.Parse(a_String);
}

int PrintSumlNumbers(int numberM, int numberN)
{
  if (numberM > numberN) return 0;

  return PrintSumlNumbers (numberM, numberN-1)+numberN;

}

int numberM = Prompt("Введите число M: ");
int numberN = Prompt("Введите число N: ");

System.Console.WriteLine();

int a = PrintSumlNumbers (numberM, numberN);
Console.WriteLine($"сумма натуральных чисел = {a} ");