int[] arr = new int[10];
Random r = new Random();
int zeroCounter = 0, oneCounter = 0;

for (int i = 0;i < arr.Length; i++)
{
    arr[i] = r.Next(0, 2);
    if (arr[i] == 0) zeroCounter++;
    else oneCounter++;
    Console.Write(arr[i]);
}
Console.WriteLine();
Console.Write($"Кол-во нулей: {zeroCounter}, кол-во единиц: {oneCounter}");