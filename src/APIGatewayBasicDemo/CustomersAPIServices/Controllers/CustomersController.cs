using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;


namespace CustomersAPIServices.Controllers
{
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {        
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Tom Zamana", "Gigi Zamana" };
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"Francis Zamana - {id}";
        }            
    }
}
