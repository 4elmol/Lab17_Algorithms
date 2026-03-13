int[] a = { 5, 4, 5, 3, 4, 5, 4, 3 };
int max = a[0];
int i = 1;

while (i < a.Length)
{
    if (a[i] > max)
    {
        max = a[i];
    }
    i = i + 1;
}
Console.WriteLine(max);