
void FillArray(int[] collecton)
{
    int length = collecton.Length;
    int index = 0;
    while (index < length)
    {
        collecton[index] = new Random().Next(1, 10);
        index++;
    }

}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}


int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index=0;
    int position=-1;//если указать значение 0 - покажет на индекс 0 при попытке поиска несуществующего элемента

    while(index<count)
    {
        
       if(collection[index]==find)
       {
        position=index;
        break;//не будет прогонять весь цикл. остановится на первом совпадении.
       }
        index++;
    }
    
    return position;
}




int[] array = new int[10];



FillArray(array);
array[4]=4;
array[7]=4;
PrintArray(array);

Console.WriteLine();
int pos = IndexOf(array,40);
Console.WriteLine(pos);
