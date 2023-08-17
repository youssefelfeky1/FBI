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
        public void addIssue(string name ,string desc,string url)
        {
            Issue issue = new Issue();
            issue.name = name;
            issue.description = desc;
            issue.url = url;
            myappContext.Issues.Add(issue);
            myappContext.SaveChanges();
        }

        public IQueryable<Issue> searchIssue(string name)
        {
            var retIssue = myappContext.Issues.Where(x => x.name == name);
            return retIssue;
            
            

        }
    }
}
