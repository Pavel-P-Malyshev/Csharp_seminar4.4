/*
Напишите программу, которая будет преобразовывать 
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}

int[] DecToBin(int dec)
{

    //елсли логафирм целое число, то увеличиваем размер на единицу, если нет то округляем в большую сторону
    double size = ( Math.Log2(dec)==(int)Math.Log2(dec)) ? Math.Log2(dec) + 1 : Math.Ceiling(Math.Log2(dec));
    //double size=Math.Ceiling(Math.Log2(dec));
    int[] answer=new int[(int)size];

    //answer[0]=dec%2;
    

    for (int index = 0; index < size; index++)
    {
        
        answer[index]=dec%2;
        dec=dec/2;

       
    }

    return answer;

}

//распечатка массива
void RvsPrintArray (int[] col)
{

    int count=col.Length;
    int position=count-1;

    Console.Write("[ ");
    while(position>=0) 
    {
        if(position==0)  {Console.Write($"{col[position]}");}
        else {Console.Write($"{col[position]}, ");}
        
        position--;
    }
    Console.WriteLine("] ");

}

int dec=Prompt("enter you dec number: ");
Console.WriteLine("Your BIN number is: ");
RvsPrintArray(DecToBin(dec));

