int[] array = { 12, 93, 34, 45, 56, 67, 45, 78, 89 };

int n = array.Length;
int find = 45;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}