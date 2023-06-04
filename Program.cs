// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter first number:");

double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter operator (+-*/)");

string op = Console.ReadLine();

Console.WriteLine("Enter second number:");

double num2 = Convert.ToDouble(Console.ReadLine());

double result = 0;

switch(op) {
	case "+":
		result = num1 + num2;
		break;
	case "-":
		result = num1 - num2;
		break;
	case "/":
		result = num1 / num2;
		break;
	case "*":
		result = num1 * num2;
		break;
}

Console.WriteLine(result);