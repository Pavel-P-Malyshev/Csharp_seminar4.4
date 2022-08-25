/*
Напишите программу, которая будет создавать 
копию заданного массива с помощью поэлементного 
копирования.
*/
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

int[] CopyArray(int[] arr)
{
    int[] answer=new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        answer[i]=arr[i];
    }

    return answer;
}

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}

int[] array=FillArray(Prompt("ENter array size: "), Prompt("Enter start value: "), Prompt("Enter end value: "));
Console.WriteLine("Your array is : ");
PrintArray(array);
Console.WriteLine("Your copied array is : ");
int[] copy=CopyArray(array);
PrintArray(copy);
