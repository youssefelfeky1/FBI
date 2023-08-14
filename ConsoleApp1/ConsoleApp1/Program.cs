using ConsoleApp1;
using ConsoleApp1.model;
using Microsoft.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
       

    Again:
        Console.WriteLine("Enter A to add new issue or S to search\n");
        string input = Console.ReadLine();
        MyappContext myappContext=new MyappContext();
        


        if (input == "A" || input=="a")
        {
           

            Issue issue = new Issue();


            Console.WriteLine("Enter Issue name:\n");
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
                Console.WriteLine("Enter Correct name ,pls\n");
                goto searchagain;
            }



           
            

        }
        else
        {
            goto Again;
        }

    }
}