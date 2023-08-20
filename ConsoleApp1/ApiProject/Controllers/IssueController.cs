using Arch.EntityFrameworkCore.Internal;
using ConsoleApp1.Business;
using ConsoleApp1.Business.model;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Reflection;

namespace ApiProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IssueController : ControllerBase
    {

        IssueBusiness issueBusiness = new IssueBusiness();



        [HttpGet("name/{name}")]
        [ProducesResponseType(typeof(Issue), 200)]
        public List<Issue> GetBy(string name)
        {
            return  issueBusiness.searchIssue(name);
        }

        [HttpPost("addIssue")]
        public void Post(Issue issue)
        {
             issueBusiness.addIssue(issue);
            
        }
    }
}