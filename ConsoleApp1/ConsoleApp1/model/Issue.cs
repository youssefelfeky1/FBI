using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.model
{
    public class Issue
    {
        private readonly string name;
        private readonly string description;
        private readonly string url;

        public Issue(string name, string description, string url)
        {
            this.name = name;
            this.description = description;
            this.url = url;
        }
    }
}
