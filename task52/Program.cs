// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

int userRows = GetNumberFromUser("Введите желаемое количество строк в массиве: ",
 "Ошибка ввода, повторите ввод");
int userColumns = GetNumberFromUser("Введите желаемое количество столбцов в массиве: ",
 "Ошибка ввода, повторите ввод");
int[,] userArray = GetArray(userRows, userColumns);
PrintArray(userArray);
ArithmeticMeanColumnArray(userArray);


int GetNumberFromUser(string message, string errorMessage)
{
  while (true)
  {
    Console.Write(message);
    var isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
    if (isCorrect)
      return userNumber;
    Console.WriteLine(errorMessage);
  }
}

int[,] GetArray(int rows, int columns)
{
  int[,] result = new int[rows, columns];
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      result[i, j] = new Random().Next(0, 10);
    }
  }
  return result;
}

void PrintArray(int[,] inArray)
{
  Console.WriteLine();
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    for (int j = 0; j < inArray.GetLength(1); j++)
      Console.Write($"{inArray[i, j]}   ");
    Console.WriteLine();
  }
}

void ArithmeticMeanColumnArray(int[,] inArray)
{
  Console.WriteLine();
  Console.Write("Среднее арифметическое каждого столбца: ");
  for (int j = 0; j < inArray.GetLength(1); j++)
  {
    double total = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
      total += inArray[i, j];
    }
    total = Math.Round(total / inArray.GetLength(0), 2);
    Console.ForegroundColor = ConsoleColor.Red;
    if (j == inArray.GetLength(1) - 1)
      Console.Write($"{total}.");
    else
      Console.Write($"{total}; ");
    Console.ResetColor();
  }
  Console.WriteLine();
}
