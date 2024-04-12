using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.Linq;

namespace WebAPIdotnet6Versioning.Controllers.v1
{
    [ApiVersion("1.0")]
    [Route("api/V{version:apiVersion}/[controller]")]
    [ApiController]
    public class CoffeeController : ControllerBase
    {
        Queue<string> CoffeeList = new Queue<string>();
        
        [HttpGet("Info")]
        public string Info()
        {
            
            return "This is version 1";
        }
        [HttpGet("DateNow")]
        public DateTime DateTime()
        {
            return DateAndTime.Now;
        }
        [HttpGet("List")]
        public string ListCoffee()
        {
            CoffeeList.Enqueue("Black Coffee");
            CoffeeList.Enqueue("Lattee");
            CoffeeList.Enqueue("Mocha");
            CoffeeList.Enqueue("Cappuccino");
            CoffeeList.Enqueue("Flat White");
            return $"We have {CoffeeList.Count}  types of Coffee";
            
        }
        
    }
}
