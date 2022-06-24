//Имеется одномерный массив array из n элементов. 
//Требуется найти элемент массива, равный find.

int[] array = { 1, 21, 67, 43, 67, 65, 67, 8 };

int n = array.Length;
int find = 67;

int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index=index+1
    index++;
}