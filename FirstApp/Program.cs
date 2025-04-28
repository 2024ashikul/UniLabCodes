using System;



namespace first{
class Print{
    static void printName(string firstname,string secondname){
        Console.WriteLine(firstname + " " + secondname);
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Hi there");
        Print.printName("ashikul","islam");

    }
    
}
}