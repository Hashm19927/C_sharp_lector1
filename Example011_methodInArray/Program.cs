int[] array={1,12,13,14,15,16,17,18,19};

int n =array.Length;
int find =4;

int index=0;

while (index<n)
{
    if (array[index]==find)
    {
        Console.WriteLine(index);
    }
    index++;
}