using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Business.model
{
    public class Issue
    {

        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string url { get; set; }

        //public Issue(string name, string description, string url)
        //{
        //    this.name = name;
        //    this.description = description;
        //    this.url = url;
        //}
    }
}
