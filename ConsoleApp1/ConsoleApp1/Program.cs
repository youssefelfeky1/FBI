using ConsoleApp1.model;

class Program
{
    static void Main(string[] args)
    {
        Again:
        Console.WriteLine("Enter A to add new issue or S to search\n");
        string input = Console.ReadLine();


        if (input == "A" || input=="a")
        {
            string name;
            string description;
            string url;
            Console.WriteLine("Enter Issue name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter Issue description:");
            description = Console.ReadLine();
            Console.WriteLine("Enter Issue URL :");
            url = Console.ReadLine();
            Issue issue = new(name, description, url);


        }
        else if(input=="s"||input=="S")
        {
            Console.WriteLine("Enter Issue name :");
            string name = Console.ReadLine();
        }
        else
        {
            goto Again;
        }

    }
}