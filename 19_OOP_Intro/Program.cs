// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine();
//Console.WriteLine();

//Object oriented programming is based on the concept of objects containing data and methods..

//DateTime

//List<string> list = new List<string>();

//var pizzaDay = new DateTime(2025, 4, 3);

//Console.WriteLine(pizzaDay.Year);
//Console.WriteLine(pizzaDay.Month);
//Console.WriteLine(pizzaDay.Day);
//Console.WriteLine(pizzaDay.DayOfWeek);

//Console.WriteLine($"The next pizza day will be on " + pizzaDay.AddYears(1));

//Console.ReadKey();

//Abstraction
//Only essential data and information is given to the user
//Abstraction means that classes expose only essential data and methods and hide the underlying details..

//Classes
//How to define a class
//What the fields of a class are
//What the default values of fields are
//What a default constructor is

//Fields
//Property
//Methods
//Construct

var rectangle1 = new Rectangle(7,12);

//Console.WriteLine(rectangle1.width);
//Console.WriteLine(rectangle1.height);

var rectangle2 = new Rectangle(6,78);
Console.WriteLine("Area of rectangle2 is: " + rectangle2.CalculateArea());
rectangle2.CalculatePerimeter();
//var rectangle3 = new Rectangle();

Console.ReadKey();

class Rectangle
{
    //Alan ve çevrfe hesabı yapmak..

    //Fields - Class değişkenleri.
    //All the attributes class will have.
    int width;
    int height;

    //Construct
    public Rectangle(int width, int height)
    {
       //_width = width;
       //_height = height;

        this.width = width;
        this.height = height;
    }

    public Rectangle(float width, float height)
    {
        
    }

    //Methods
    public int CalculateArea()
    {
        return width * height;
    }

    public void CalculatePerimeter()
    {
        int perimeter = 2 * (width + height);
        Console.WriteLine("Perimeter of the rectangle is: " + perimeter);
    }
   
}

class Square
{

}

class Triangle
{

}

