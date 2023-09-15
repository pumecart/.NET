using System;

class Program
{
    static void Main()
    {
        string name = "Pumehana";
        string location = "Connecticut";


        Console.WriteLine("My name is " + name + ", I am from " + location);

        var currentDate = DateTime.Now;
        Console.WriteLine($"Today's date is {currentDate.ToString("MM/dd/yyyy")}");

        var christmasDate = new DateTime(DateTime.Now.Year, 12, 25);
        var diff = (christmasDate - DateTime.Now);
        Console.WriteLine($"Number of days till Christmas: {diff.Days}");

        double width, height, woodLength, glassArea;
        string widthString, heightString;
        widthString = Console.ReadLine();
        width = double.Parse(widthString);
        heightString = Console.ReadLine();
        height = double.Parse(heightString);
        woodLength = 2 * (width + height) * 3.25;
        glassArea = 2 * (width * height);
        Console.WriteLine("What is the length of the wood?");
        Console.WriteLine("The length of the wood is " +
               woodLength + " feet");
        Console.WriteLine("What is the area of the glass?");
        Console.WriteLine("The area of the glass is " +
               glassArea + " square metres");

        Console.ReadKey();
    }
}


