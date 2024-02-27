
int[] array = new int[7] { 5, 9, 1, 3, 69, 6, 4 };

for (int i = 0; i < array.Length - 1; i++)
{
    int j = i + 1;
    int tmp = array[j];
    while (j > 0 && tmp > array[j - 1])
    {
        array[j] = array[j - 1];
        j--;
    }
    array[j] = tmp;
}


Console.WriteLine("Sorted array:");
foreach (int element in array)
{
    Console.Write(element + " ");
}