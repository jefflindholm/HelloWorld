using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HWApi.Controllers
{
    [Route("api/[controller]")]
    public class MessageController : Controller
    {
        private string FormatMessage(string name) {
            return string.Format("Hello {0}!", name);
        }
        // GET api/values
        [HttpGet]
        public string Get()
        {
            return FormatMessage("World");
        }

        // GET api/values/5
        [HttpGet("{name}")]
        public string Get(string name)
        {
            return FormatMessage(name);
        }

        // POST api/values
        [HttpPost]
        public string Post([FromBody]string name)
        {
            return FormatMessage(name);
        }
    }
}
