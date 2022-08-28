// Задача 50: Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();

int userRows = new Random().Next(1, 5);
int userColumns = new Random().Next(1, 5);
Console.WriteLine("Нумерация массива начинается с 0, 0");
int numberRow = GetNumberFromUser("Введите номер интересующей Вас строки: ",
 "Ошибка ввода, повторите ввод");
int numberColumn = GetNumberFromUser("Введите номер интересующего Вас столбца: ",
 "Ошибка ввода, повторите ввод");
double[,] userArray = GetArray(userRows, userColumns);
PrintArray(userArray);
ResponseIsThereAnElement(userArray, numberRow, numberColumn);


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
  Console.WriteLine();
}

void ResponseIsThereAnElement(double[,] inArray, int numberRow, int numberColumn)
{
  if (numberRow < inArray.GetLength(0) && numberColumn < inArray.GetLength(1))
    Console.WriteLine($"{numberRow}, {numberColumn}  -->  {inArray[numberRow, numberColumn]}");
  else
    Console.WriteLine($"Такого числа в массиве нет");
}