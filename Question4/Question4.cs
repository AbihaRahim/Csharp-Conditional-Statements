using System;

public class HelloWorld {
    public static void Main(string[] args) {

        Console.WriteLine("StudentID: 66568, Name: Abiha Rahim, Date: 10/25/2026");
    
        Console.WriteLine("Enter the first number:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter an operator (+, -, *, /):");
        char op = char.Parse(Console.ReadLine());

        switch (op)
        {
            case '+':
                Console.WriteLine("Result: " + (num1 + num2));
                break;

            case '-':
                Console.WriteLine("Result: " + (num1 - num2));
                break;

            case '*':
                Console.WriteLine("Result: " + (num1 * num2));
                break;

            case '/':
                 if (num2 != 0)
                    Console.WriteLine("Result: " + (num1 / num2));
                else
                    Console.WriteLine("Cannot divide by zero.");
                break;

            default:
                Console.WriteLine("Invalid operator.");
                break;
    }
}
}
