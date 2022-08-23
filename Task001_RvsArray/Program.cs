/*
Демонстрация решения
Задача 1: Напишите программу, которая перевернёт 
одномерный массив (последний элемент будет на первом 
месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]

*/




int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}

//распечатка массива
void PrintArray (int[] col)
{

    int count=col.Length;
    int position=0;

    Console.Write("[ ");
    while(position<count) 
    {
        if(position==count-1)  {Console.Write($"{col[position]}");}
        else {Console.Write($"{col[position]}, ");}
        
        position++;
    }
    Console.WriteLine("] ");

}


int[] FillArray(int size, int min, int max)
{
    int[] array=new int[size];
   
    Random rnd=new Random();

    for(int i=0;i<array.Length;i++)
    {
        array[i]=rnd.Next(min,max+1);
          
    }

    return array;
    
}


int[] RvsArray(int[] arr)
{
    int[] array=new int[arr.Length];
   
    int temp=0;

    for(int i=0;i<array.Length/2-1;i++)
    {
        temp=arr[i];
        arr[i]=arr[arr.Length-1-i];
        arr[arr.Length-1-i]=temp;
          
    }

    return array;
    
}


int[] SrcArr=FillArray(Prompt("enter array size: "),Prompt("Enter min threshold: "), Prompt("Enter max threshold: "));
System.Console.WriteLine (" Original Array:");
PrintArray(SrcArr);
System.Console.WriteLine (" Reversed Array:");
int[] RvsArr=RvsArray(SrcArr);
PrintArray(SrcArr);






