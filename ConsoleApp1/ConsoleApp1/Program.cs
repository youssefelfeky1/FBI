using ConsoleApp1.model;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter A to add new issue or S to search\n");
        string input = Console.ReadLine();


        if (input == "A" || input=="a")
        {
           string name;
         string description;
         string url;
            Console.WriteLine("Enter Issue name\n");
            name = Console.ReadLine();
            Console.WriteLine("Enter Issue description\n");
            description = Console.ReadLine();
            Console.WriteLine("Enter Issue URL\n");
            url = Console.ReadLine();
            Issue issue = new(name, description, url);


        }
        else if(input=="s")
        {
            Console.WriteLine("Enter Issue name\n");
            string name = Console.ReadLine();
        }

    }
}