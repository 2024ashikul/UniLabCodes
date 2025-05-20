using System;

class Circle{
    public int id;
    public double diameter;
    public Circle(int a,double b){
        id = a;
        diameter =b;
    }
}

class Rectangle{
    public int id;
    public double height,width;
    public Rectangle(int a,double b,double c){
        id = a;
        height =b;
        width = c;
    }
}
class Cube{
    public int id;
    public double height,width,depth;
    public Cube(int a,double b,double c,double d){
        id = a;
        height = b;
        width = c;
        depth = d;
    }
}
class Program{
    static void Main(){
        List<Circle> circles = new List<Circle>();
        //Circle[] circles = new Circle[100];
        List<Rectangle> rectangles = new List<Rectangle>();
        //Cube[] cubes = new Cube[100];
        List<Cube> cubes = new List<Cube>();
        int cirid = 1,recid = 1,cubeid=1;
        int temp = 1;
        int test = 1;
        while(true){
            if(test == 0){
                break;
            }
            Console.WriteLine("\nPlease select a option");
            Console.WriteLine("1. Add a Circle");
            Console.WriteLine("2. Add a Rectangle");
            Console.WriteLine("3. Add a Cube");
            Console.WriteLine("4. List Items");
            Console.WriteLine("5. Exit");

            int n = Convert.ToInt32(Console.ReadLine());
            switch(n){
                
                case 1:
                    int ab = cirid;cirid++;
                    Console.Write("Diameter:");
                    double bc = Convert.ToDouble(Console.ReadLine());
                    
                    circles.Add(new Circle(ab,bc));
                    temp++;
                break;
                case 2:
                    int p = recid;recid++;
                    Console.Write("Height:");
                    double q = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Width:");
                    double r = Convert.ToDouble(Console.ReadLine());
                    rectangles.Add(new Rectangle(p,q,r));
                    temp++;
                break;
                case 3:
                    int x = cubeid;cubeid++;
                    Console.Write("Height:");
                    double y = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Width:");
                    double z = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Depth:");
                    double zz = Convert.ToDouble(Console.ReadLine());
                    cubes.Add(new Cube(x,y,z,zz));
                    temp++;
                break;
                case 4:
                    Console.WriteLine("\nCircle list");
                    Console.WriteLine("ID       Type        Dimension ");
                    Console.WriteLine("============================");
                    
                    foreach(Circle i in circles){
                            Console.WriteLine($"{i.id}     Circle      {i.diameter}");

                    }
                    Console.WriteLine("\nRectangle list");
                    Console.WriteLine("ID       Type        Dimension ");
                    Console.WriteLine("============================");
                    foreach(Rectangle i in rectangles){
                        
                            Console.WriteLine($"{i.id}     Rectangle      {i.height}X{i.width}");
                    }
                    Console.WriteLine("\nCube list");
                    Console.WriteLine("ID       Type        Dimension ");
                    Console.WriteLine("============================");
                    foreach(Cube i in cubes){
                            Console.WriteLine($"{i.id}     Cube      {i.height}X{i.width}X{i.depth}");
                    }
                    
                break;
                case 5:
                    test = 0;
                break;
            }
        }

        Console.WriteLine(circles[1].id);
    }
}