int[] pole = new int[7] { 6, 5, 1, 3, 4, 7, 2 };

int j = 0;

for (int i = 0; i < pole.Length; i++)
{
    
    while (pole[i] > pole[j])
    {
        int temp = pole[i];
        pole[i] = pole[j];
        temp = pole[j];
    }
    

}

foreach (int element in pole)
{
    Console.WriteLine(element + " ");
}


