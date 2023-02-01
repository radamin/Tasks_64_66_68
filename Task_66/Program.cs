// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Input first natural number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second natural number: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NaturalNumberSum(firstNum, secondNum));


int NaturalNumberSum(int firstNum, int secondNum)
{
  if (firstNum == secondNum) return firstNum;

  if (firstNum > secondNum) return secondNum + NaturalNumberSum(firstNum, secondNum + 1);

  return firstNum + NaturalNumberSum(firstNum + 1, secondNum);
}

