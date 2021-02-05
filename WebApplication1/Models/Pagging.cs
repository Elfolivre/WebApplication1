using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{ 
    [HttpPost]
    public class Pagging
    {   
        [Route("receber/{PageSize;string}")]
        public int PageSize { set; }
        [Route("receber/CurrentPage;string")]
        public int CurrentPage { set; }
    }
}
