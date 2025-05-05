using System;

namespace Hello{
    public class Circle{
    public double radius,area;
    
}


public class Program {
    static void Main(string[] args){
        int n= Convert.ToInt32(Console.ReadLine());
        //int n =int.Parse(Console.ReadLine()) ;
        Circle[] circle_arr = new Circle[n];
        for(int i=0;i < n;i++){
            circle_arr[i]= new Circle();
            Console.WriteLine("Enter the radius of the circle");
            circle_arr[i].radius = Convert.ToDouble(Console.ReadLine());
            
        }
       
        for(int i=0;i < n;i++){
            
            Console.WriteLine(i + "   "  +circle_arr[i].radius);
            
        }
    }
}
}