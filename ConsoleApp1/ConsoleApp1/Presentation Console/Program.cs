using ConsoleApp1.Business;
using ConsoleApp1.Business.model;
using ConsoleApp1.DataAcess;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        IssueBusiness issueBusiness = new IssueBusiness();



    askAgain:

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Enter A to add new issue , S to search or E to exit\n");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        string input = Console.ReadLine();


        



        //Add new issue
        if (input == "A" || input=="a")
        {
          

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("\nEnter Issue name:\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("\nEnter Issue description:\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string description = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("\nEnter Issue URL:\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string url = Console.ReadLine();
            



         

            Console.ForegroundColor = ConsoleColor.Red;
            issueBusiness.addIssue(name,description,url);
            Console.WriteLine("\nIssue added successfully\n");
            goto askAgain;


            






        }
        //Search for issue
        else if(input=="s"||input=="S")
        {

         searchagain:

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nEnter Issue name :\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string name = Console.ReadLine();





            var retIssue = issueBusiness.searchIssue(name);
            
            if(retIssue.Count()!=0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nIssue name: " + retIssue.First().name);

                Console.WriteLine("Issue description: " + retIssue.First().description);

                Console.WriteLine("Issue URL: " + retIssue.First().url+"\n");

                goto askAgain;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nEnter Correct name ,pls🥺!\n");
                goto searchagain;
            }



           
            

        }
        else if(input=="e"||input=="E")
        {
            return;
        }
        else
        {
            goto askAgain;
        }

    }
}