Console.WriteLine("Hello!");
Console.Write("Input the first number: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Input the second number: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");
Console.Write("Choice: ");

string userChoice = Console.ReadLine();

if (EqualsCaseInsensitive(userChoice, "A"))
{
    PrintFinalEquation(a, b, Sum(a, b), "+");
}
else if (EqualsCaseInsensitive(userChoice, "S"))
{
    PrintFinalEquation(a, b, Subtraction(a, b), "-");
}
else if (EqualsCaseInsensitive(userChoice, "M"))
{
    PrintFinalEquation(a, b, Multiply(a, b), "*");
}
else
{
    Console.WriteLine("Invalid option” is printed to the console");
}

Console.WriteLine("Press any key to close");
Console.ReadKey();

int Sum(int a, int b)
{
    return a + b;
}

int Subtraction(int a, int b)
{
    return a - b;
}

int Multiply(int a, int b)
{
    return a * b;
}

void PrintFinalEquation (int number1, int number2, int result, string @operator)
{
    Console.WriteLine($"{number1} {@operator} {number2} = {result}");
}

bool EqualsCaseInsensitive(string left, string  right)
{
    return left.ToUpper() == right.ToUpper();
}