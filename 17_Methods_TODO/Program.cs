// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

Console.WriteLine("Hello");


Console.WriteLine("What do you want to do?");
Console.WriteLine("Press S to see all TODOs");
Console.WriteLine("Press A to add a TODO");
Console.WriteLine("Press R to remove a TODO");
Console.WriteLine("Press E to exit");
Console.WriteLine();

bool shallExit = false;

var todos = new List<string>();

while(!shallExit)
{
    var userInput = Console.ReadLine();

    switch (userInput)
    {
        case "S":
        case "s":
            //Console.WriteLine("See All TODOs");
            SeeTodo();
            break;
        case "A":
        case "a":
            //Console.WriteLine("Add a TODO");
            AddTodo();
            break;
        case "R":
        case "r":
            Console.WriteLine("Remove a TODO");
            RemoveTodo();
            break;
        case "E":
        case "e":
            //Console.WriteLine("Exit");
            shallExit = true;
            break;
        default:
            Console.WriteLine("You have entered a wrong input");
            break;

    }
}

//break - Methodtan çıkmak için
//continue - Methoddaki diğer kod bloklarına devam etmek için

Console.WriteLine("You are exiting the program");
Console.ReadKey();

void AddTodo()
{ 
    Console.WriteLine("Please enter a todo description");
    string description = Console.ReadLine();
    if(description == "")
    {
        Console.WriteLine("Description can not be empty");
    }
    else if(todos.Contains(description)) 
    {
        Console.WriteLine("Description must be unique"); 
    }
    else
    {
        todos.Add(description);
        Console.WriteLine("Printing todo list: ");
        SeeTodo();
    }
}

void SeeTodo()
{
    if (todos.Count == 0)
    {
        ShowNoTodoMessage();
    }

    for (int i = 0; i < todos.Count; i++)
    {
        Console.WriteLine($"{i+1}.{todos[i]}");
    }

}
void RemoveTodo()
{
    
    
    if (todos.Count == 0)
    {
        ShowNoTodoMessage();
    }

    
    Console.WriteLine("Please select the number to remove a todo");
    var userInput = Console.ReadLine();
    //removeIndex = int.Parse(Console.ReadLine());
    bool isValid = int.TryParse(userInput, out int index);

    if(isValid)
    {
        
        Console.WriteLine("You removed todo: " + todos[index - 1]);
        todos.RemoveAt(index - 1);
        SeeTodo();
    }
    else
    {
        Console.WriteLine("You have entered wrong input");
    }

    
}
void ShowNoTodoMessage()
{
    Console.WriteLine("No todos are added");
}