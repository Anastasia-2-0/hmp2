// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
 void FillArray(int[] collection){
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}
void PrintArray(int[] col){
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(col[position]);
        position++;
    }
}



int[] array =new int[new Random().Next(1,20)];
int length = array.Length;

if(length < 3){
    Console.WriteLine("Третьей цифры нет");
}
else{
    FillArray(array);
    PrintArray(array);
    Console.WriteLine($" Третий элемент данного массива " +  array[2]);
}

