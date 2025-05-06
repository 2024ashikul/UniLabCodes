using System;

class Circle{
    public int id;
    public double diameter;
}

class Rectangle{
    public int id;
    public double height,width;
}
class Cube{
    public int id;
    public double height,width,depth;
}
class Program{
    static void Main(){
        Circle[] circles = new Circle[100];
        Rectangle[] rectangles = new Rectangle[100];
        Cube[] cubes = new Cube[100];
    }
}