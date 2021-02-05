using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{ [
    Route("api/[controller]")]
    [ApiController]
    public class Paging
    {   
       [Route("/articles/{page}")]
        public int PageSize { get ;set; }
        
        [Route("/articles/{page}")]
        public int CurrentPage { get;  set; }
    }
}
