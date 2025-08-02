bool isParsingSucessful;

do
{
    Console.Write("Enter a number: ");
    string userInput = Console.ReadLine();
    isParsingSucessful = int.TryParse(userInput, out int number);

    if (isParsingSucessful)
    {
        Console.WriteLine("Parsing worked, number is: " + number);

    }
    else
    {
        Console.WriteLine("Parsing failed");
    }

} while (!isParsingSucessful);

Console.ReadKey();