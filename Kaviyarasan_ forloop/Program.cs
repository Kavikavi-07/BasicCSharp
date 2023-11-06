using System;
namespace forloop;
class Program{
    public static void Main(string[] args)
    { 
        Console.WriteLine("Enter the number1: ");
        int num1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number2: ");
        int num2=Convert.ToInt32(Console.ReadLine());
        int result=0;
        for(int i=num1;i<=num2;i++)
        {
            result=result+(i*i);
        }
        Console.WriteLine(result);
        


    }
}