using System;

public class Program
{
    public static void Main ()
    {
        // perimeter: 2l + 2h
        // area: l * w
        // volume: l * w * h
        // surface area: 2lw + 2wh + 2lh

        Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
        
        Console.Write("Enter Length: ");
        double length = double.Parse(Console.ReadLine());
       
        Console.Write("Enter Width: ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Enter Height: " );
        double height = double.Parse(Console.ReadLine());

        double perimeter = 2 * length + 2 * width;
        double area = length * width;
        double volume = length * width * height;
        double surfArea = 2 * length * width + 2 * width * height + 2 * length * height;

        Console.WriteLine("Area: " + area);
        Console.WriteLine("Perimeter: " + perimeter);
        Console.WriteLine("Volume : " + volume);
        Console.WriteLine("Surface Area: " + surfArea);

        if (area <= 250)
        {
            Console.WriteLine("This is a small-sized room.");
        } else if (area > 250 && area < 650)
        {
            Console.WriteLine("This is a medium-sized room.");
        } else
        {
            Console.WriteLine("This is a large-sized room.");
        }

        Console.WriteLine("Thank you for using the Room Detail Generator!");


    }
}


// Explain in 3 detailed steps how to get input from the user, do calculations to the input to create a new variable, then display it back to the user

/* 1. How to get input from the user: Use "Console.ReadLine()"
 * 2. How to do calculations to the input to create a new variable: To be able to work with user input, you have to parse it and convert from a string to a diffent data type. ex: int userInput = int.Parse(Console.ReadLine());
 * 3. How to display it back to the user: "Console.WriteLine(userInput); */

