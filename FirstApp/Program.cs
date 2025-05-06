using System;

namespace Calculator{
    class Program{
        public static void Main(string[] args){
            double number1,number2,result;
            Console.WriteLine("Enter the number 1 \n");
            number1= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number 2\n");
            number2= Convert.ToDouble(Console.ReadLine());
            double summation = number1+number2;
            Console.WriteLine("Summation is " + summation);


            Console.WriteLine("Enter your choice (+-/*):");
            string choice = Console.ReadLine();;
            //choice = 

            switch(choice){
                case "+":
                    result = number1+number2;
                    Console.WriteLine("Result is " + result);
                    break;
                case "-":
                    result = number1-number2;
                    Console.WriteLine("Result is " + result);
                    break;
                case "*":
                    result = number1*number2;
                    Console.WriteLine("Result is " + result);
                    break;
                case "/":
                    result = number1/number2;
                    Console.WriteLine("Result is " + result);
                    break;
                case "%":
                    result = number1%number2;
                    Console.WriteLine("Result is " + result);
                    break;
                case "^":
                    result = Math.Pow(number1,number2);
                    Console.WriteLine("Result is " + result);
                    break;
            
                default:
                    Console.WriteLine("Error :");
                    break;
            }
        }
}
}
