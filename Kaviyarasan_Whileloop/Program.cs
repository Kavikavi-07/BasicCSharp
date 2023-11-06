using System;
namespace whileloop;
class Program{
    public static void Main(string[] args)
    {
      int a=0;
      while(a<=25){
         if(a%2==0 && a!=0){
             Console.WriteLine(a);
         }
         a++;
      }
      Console.WriteLine($"Enter the number:");
      string input = Console.ReadLine();
      bool temp = int.TryParse(input,out int result);
      while(!temp){
      Console.WriteLine($"please enter a valid number again : ");
      temp=int.TryParse(Console.ReadLine(),out result);
      }
     
     
    }
}
