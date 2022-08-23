/*
Напишите программу, которая принимает на вход три 
числа и проверяет, может ли существовать треугольник с сторонами 
такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника 
меньше суммы двух других сторон
*/


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}

bool IsTriangle(int a, int b, int c)
{
    if((a<(b+c))&&(b<(a+c))&&(c<(a+b))) return true;
    return false;
}

int a=Prompt("enter a side:  ");
int b=Prompt("enter b side:  ");
int c=Prompt("enter c side:  ");

if(IsTriangle(a,b,c)) {Console.WriteLine($"the triangle with sides a,b,c may exist");}
else {Console.WriteLine($"the triangle with sides a,b,c may not exist");}

