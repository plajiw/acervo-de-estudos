bool userExit = false;
List<string> todoList = new List<string>();

do
{
    Menu();
    Console.Write("Select: ");
    var userChoice = Console.ReadLine();

    switch (userChoice)
    {
        case "S":
        case "s":
            ListAllTodo();
            break;

        case "A":
        case "a":
            AddTodo();
            break;

        case "R":
        case "r":
            RemoveTodo();
            break;

        case "E":
        case "e":
            userExit = true;
            break;

        default:
            Console.WriteLine("Invalid choice");
            break;
    }
}
while (!userExit);

Console.ReadKey();

void Menu()
{
    Console.WriteLine("\nWhat do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit\n");
}

void ListAllTodo()
{
    if (todoList.Any())
    {
        for (int i = 0; i < todoList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {todoList[i]}");
        }
    }
    else
    {
        Console.WriteLine("No TODOs have been added yet");
    }
}

void AddTodo()
{
    bool isValidDescription = false;
    while (!isValidDescription)
    {
        Console.Write("Enter the TODO description: ");
        string todo = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(todo))
        {
            Console.WriteLine("The description cannot be empty");
        }
        else if (todoList.Contains(todo))
        {
            Console.WriteLine("The description must be unique.");
        }
        else
        {
            isValidDescription = true;
            todoList.Add(todo);
            Console.WriteLine("TODO added successfully.");
        }
    }
}

void RemoveTodo()
{
    if (todoList.Count == 0)
    {
        Console.WriteLine("No TODOs have been added yet.");
        return;
    }

    Console.WriteLine("Select the index of the TODO you want to remove:");
    ListAllTodo();

    Console.Write("Index: ");
    var userChoice = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(userChoice))
    {
        Console.WriteLine("Selected index cannot be empty.");
        return;
    }

    if (int.TryParse(userChoice, out int index))
    {
        if (index >= 1 && index <= todoList.Count)
        {
            string removed = todoList[index - 1];
            todoList.RemoveAt(index - 1);
            Console.WriteLine($"Removed TODO: {removed}");
        }
        else
        {
            Console.WriteLine("Invalid index. Please select a valid number.");
        }
    }
    else
    {
        Console.WriteLine("Please enter a numeric index.");
    }
}
