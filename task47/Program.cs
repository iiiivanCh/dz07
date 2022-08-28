// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

int userRows = GetNumberFromUser("Введите желаемое количество строк в массиве: ",
 "Ошибка ввода, повторите ввод");
int userColumns = GetNumberFromUser("Введите желаемое количество столбцов в массиве: ",
 "Ошибка ввода, повторите ввод");
PrintArray(GetArray(userRows, userColumns));


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

double[,] GetArray(int rows, int columns)
{
  double[,] result = new double[rows, columns];
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      result[i, j] = Math.Round((new Random().NextDouble() * 10), 1);
      int evenOfOdd = new Random().Next(0, 9);
      if (evenOfOdd % 2 == 0)
        result[i, j] *= -1;
    }
  }
  return result;
}

void PrintArray(double[,] inArray)
{
  Console.WriteLine();
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
      if (inArray[i, j] >= 0)
        Console.Write($" {inArray[i, j]}\t");
      else
        Console.Write($"{inArray[i, j]}\t");
    }
    Console.WriteLine();
  }
}