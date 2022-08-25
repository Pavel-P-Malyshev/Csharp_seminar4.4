/*
Не используя рекурсию, выведите первые N чисел 
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}

int[] Fibonacci(int N)
{
    int[] answer=new int[N];
    answer[0]=1;
    answer[1]=1;
    if(N==1||N==2) return answer;
    
    for (int i = 2; i < N; i++)
    {
        answer[i]=answer[i-1]+answer[i-2];
    }

   return answer;

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

int N=Prompt("Enter Fibonacci number N: ");
Console.WriteLine("N number of Fibonacci are: ");
PrintArray(Fibonacci(N));
