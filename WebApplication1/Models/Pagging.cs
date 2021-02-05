using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{    [HttpPost]   
     [Route("api/[controller]")]
    [ApiController]
    public class Paging
    {   
       [Route("/articles/{PageSize}")]
        public int PageSize {set; }
        
        [Route("/articles/{CurrentPage}")]
        public int CurrentPage {set; }
    }
}
