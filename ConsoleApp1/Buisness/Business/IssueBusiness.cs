using ConsoleApp1.Business.model;
using ConsoleApp1.DataAcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Business
{
   public class IssueBusiness
    {
        private MyappContext myappContext=new MyappContext();
        public void addIssue(Issue issue)
        {
            
            myappContext.Issues.Add(issue);
            myappContext.SaveChanges();
        }

        public List<Issue> searchIssue(string name)
        {
            var retIssue = myappContext.Issues.Where(x => x.name == name);
            return retIssue.ToList<Issue>();
            
            

        }
    }
}
