// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Basic Calculator in .NET");

// Get first number
Console.Write("Enter first number: ");
string? input1 = Console.ReadLine();
if (!double.TryParse(input1, out double num1))
{
    Console.WriteLine("Invalid input for first number.");
    return;
}

// Get operator
Console.Write("Enter operator (+, -, *, /): ");
string? op = Console.ReadLine();
if (string.IsNullOrWhiteSpace(op))
{
    Console.WriteLine("Invalid operator.");
    return;
}

// Get second number
Console.Write("Enter second number: ");
string? input2 = Console.ReadLine();
if (!double.TryParse(input2, out double num2))
{
    Console.WriteLine("Invalid input for second number.");
    return;
}

// Perform calculation
double result;
switch (op)
{
    case "+":
        result = num1 + num2;
        break;
    case "-":
        result = num1 - num2;
        break;
    case "*":
        result = num1 * num2;
        break;
    case "/":
        if (num2 == 0)
        {
            Console.WriteLine("Cannot divide by zero.");
            return;
        }
        result = num1 / num2;
        break;
    default:
        Console.WriteLine("Unknown operator.");
        return;
}

Console.WriteLine($"Result: {result}");
