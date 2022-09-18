int[] array = { 1, 12, 3, 41, 15, 16, 7, 18 };

int n = array.Length;
int find = 18;

int index = 0; 

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
