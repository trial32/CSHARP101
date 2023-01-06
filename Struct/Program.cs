
Rectangle rectangle = new Rectangle();

Console.WriteLine(rectangle.CalculateArea());

Struct_Rectangle rectangle1;
rectangle1.shortSide=3;
rectangle1.longSide=4;
Console.WriteLine(rectangle1.CalculateArea());

class Rectangle {
    public int shortSide;
    public int longSide;

    public Rectangle(){

        shortSide=3;
        longSide=4;
    }
    public int CalculateArea (){

        return shortSide * longSide;
    }
}
struct Struct_Rectangle {
    public int shortSide;
    public int longSide;

    public int CalculateArea (){

        return shortSide * longSide;
    }
}