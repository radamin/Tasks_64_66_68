
// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9


int Ackerman(int firstNum, int secondNum)
{
  if (firstNum == 0) return secondNum + 1;

  else if ((firstNum != 0) && (secondNum == 0)) return Ackerman(firstNum - 1, 1);

  Console.WriteLine($"Ackerman({firstNum}, {secondNum}) -> {Ackerman(firstNum - 1, +Ackerman(firstNum, secondNum - 1))}");
  return Ackerman(firstNum - 1, Ackerman(firstNum, secondNum - 1));
}

Console.Write("Input first number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Ackerman(firstNum, secondNum));