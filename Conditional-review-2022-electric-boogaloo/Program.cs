bool condition = false;


//conditionals
//if/else statements
if (condition)
{
    Console.WriteLine("Creative");
}
else if(5 > 2)
{
    Console.WriteLine("Something else");
}
else
{
    Console.WriteLine("Whatever");
}

//user input
//Console.ReadLine will give us a string representation of what our user types in to the console
//ToLower() will make a string lower case
var response = Console.ReadLine().ToLower();


//switch statement
switch (response)
{
    case "good day!":
        Console.WriteLine("Hello there!");
        break;
    case "good morning!":
        Console.WriteLine("Nice day isn't it?");
        break;
    default:
        Console.WriteLine("I don't quite understand");
        break;
}
if (response.Contains("good"))
{
    Console.WriteLine("Though, it is pretty good isn't it?");
}

Console.WriteLine("Please enter 1 or 2.");
int userNumber = 0;
if (int.TryParse(Console.ReadLine(), out userNumber)){
    switch (userNumber)
    {
        case 1:
            Console.WriteLine("One");
            break;
        case 2:
            Console.WriteLine("Two");
            break;
        default:
            Console.WriteLine("Please enter a number");
            break;
    }
}


