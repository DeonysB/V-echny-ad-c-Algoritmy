int[] array = new int[7] { 5, 9, 1, 3, 7, 6, 4 };


for (int i = 0; i < array.Length - 1; i++)
{
    int maxIndex = i;
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[j] > array[maxIndex]) maxIndex = j;
    }
    int tmp = array[i];
    array[i] = array[maxIndex];
    array[maxIndex] = tmp;
}

Console.WriteLine("Sorted array:");
foreach (int element in array)
{
    Console.Write(element + " ");
}