using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{ 
    [HttpPost]
    public class Pagging
    {   
        [Route("receber/{PageSize;int}")]
        public int PageSize { set; }
        [Route("receber/CurrentPage;int")]
        public int CurrentPage { set; }
    }
}
