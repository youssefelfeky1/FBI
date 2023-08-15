using ConsoleApp1;
using ConsoleApp1.model;
using Microsoft.Data.SqlClient;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;


    askAgain:
        Console.WriteLine("Enter A to add new issue , S to search or E to exit\n");
        string input = Console.ReadLine();
        MyappContext myappContext=new MyappContext();
        


        if (input == "A" || input=="a")
        {
           

            Issue issue = new Issue();


            Console.WriteLine("\nEnter Issue name:\n");
            issue.name = Console.ReadLine();

            Console.WriteLine("Enter Issue description:\n");
            issue.description = Console.ReadLine();

            Console.WriteLine("Enter Issue URL:\n");
            issue.url = Console.ReadLine();

           

            myappContext.Issues.Add(issue);
            myappContext.SaveChanges();


            






        }
        else if(input=="s"||input=="S")
        {

            searchagain:
            Console.WriteLine("Enter Issue name :\n");
            string name = Console.ReadLine();





            var retIssue = myappContext.Issues.Where(x => x.name == name);
            
            if(retIssue.Count()!=0)
            {
                Console.WriteLine("\nIssue name: " + retIssue.First().name);

                Console.WriteLine("Issue description: " + retIssue.First().description);

                Console.WriteLine("Issue URL: " + retIssue.First().url);
            }
            else
            {
                Console.WriteLine("\nEnter Correct name, pls🥺\n");
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