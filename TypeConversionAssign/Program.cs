using System;
namespace TypeConversionAssign;

    class Program;
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Trainee Details Are : ");
            Console.WriteLine("Enter your name : ");
            string name=Console.ReadLine();
            Console.WriteLine("Enter age : ");
            int age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter mark of subject1 : ");
            int Marks1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter mark of subject2 : ");
            int Marks2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter mark of subject3 : ");
            int Marks3=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Grade : ");
            int Total=Marks1+Marks2+Marks3;
            Console.Write("Total :",Total);
            int average=Total/3;
            Console.Write("Average",average);
            char Grade=Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter mobile number : ");
            int Mobilenumber=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Mail id : ");
            string Mailid=Convert.ToString(Console.ReadLine());
        }
    }
