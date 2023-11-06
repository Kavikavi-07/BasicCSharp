using System;
namespace dowhile;
class Program{
    public static void Main(string[] args)
    {   
        String option="";
        int a;
        do
        {
            Console.WriteLine("Enter the number : ");
            a=Convert.ToInt32(Console.ReadLine());
            if(a%2==0){
                Console.WriteLine("Even");
            }
            else if(a%2!=0)
            {
                Console.WriteLine("odd");
            }
            Console.WriteLine("Do you want to know other number");
            option=Console.ReadLine().ToLower();  
            while(option!="Yes" && option!="no"){
            Console.WriteLine("Input is wrong.Enter valid input ");  
            option=Console.ReadLine().ToLower();        
        } }while (option=="Yes");
        

}
}