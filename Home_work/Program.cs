void Ex47()
{
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int max = Convert.ToInt32(Console.ReadLine());
double[,] array = GetArray(rows, columns);
PrintArray(array);
double[,] GetArray(int m, int n)
{
    double[,] result = new double[m, n];
    
    for (int i = 0; i < m; i++) 
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Math.Round(new Random().NextDouble() * (max - min) + min,1);
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
            Console.Write($"{inArray[i,j]}\t");
        }
        Console.WriteLine();
    }
}
}
void Ex50()
{
int rows=5;
int columns=5;
Console.WriteLine("Введите индекс строки: ");
int rowindex = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца: ");
int columnindex = Convert.ToInt32(Console.ReadLine());
int[,] array = GetArray(rows, columns);
PrintArray(array);

if (rowindex < rows && columnindex < columns) Console.WriteLine(array[rowindex, columnindex]);
else Console.WriteLine($"{rowindex}{columnindex} -> Числа с таким адресом в массиве нет");

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++) 
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1,10);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}\t");
        }
        Console.WriteLine();
    }
}
}
void Ex52()
{
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.Write("Среднее арифметическое каждого столбца: ");

for (int i = 0; i < columns; i++) 
{
    double sum = 0;
    double average = 0;
    for (int j = 0; j < rows; j++)
    {
       {
         sum += array[j,i];
         average = sum / rows;
       }
    }
    Console.Write("{0:0.00} ", average);
}

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++) 
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1,10);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}\t");
        }
        Console.WriteLine();
    }
}
}
Ex47();
Ex50();
Ex52();

