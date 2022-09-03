int [] array = {1, 54, 65, 87, 99, 51, 20, 0};

int n = array.Length;
int find = 99;
int index = 0;

while (index<n)
{
    if(array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}