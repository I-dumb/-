int[][] JagArrGen()
{
    Console.WriteLine("Введите кол-во строк в массиве");
    int rows = Convert.ToInt32(Console.ReadLine());
    int[][] JagArr = new int[rows][];

    for(int i = 0; i<JagArr.Length;i++)
    {
        Console.WriteLine($"Введите кол-во элементов для строки {i+1}");
        JagArr[i] = new int[Convert.ToInt32(Console.ReadLine())];
    }

    for (int i = 0; i<JagArr.Length; i++)
    {
        for(int j = 0; j < JagArr[i].Length; j++)
        {
            Console.WriteLine($"Введите элемент № {j+1} в строке {i+1}");
            JagArr[i][j] = Convert.ToInt32(Console.ReadLine());
        }

    }
   return JagArr;
}

int[][] arr = JagArrGen();

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine($"\nэлементы в строке {i}:");
    for (int j = 0; j < arr[i].Length; j++)
    {
        Console.Write(arr[i][j] + "\t");
    }

}
