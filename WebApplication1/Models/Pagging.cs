using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{ 
    [HttpPost]
    public class Pagging
    {
        public int PageSize { set; }
        public int CurrentPage { set; }
    }
}
