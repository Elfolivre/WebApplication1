using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace WebApplication1.Controller

{
 [HttpPost]
    public class Pessoa
    {
    
        public int Id { set; FormMethod.Post; }
        
        
        public string Nome { set; FormMethod.Post; }
        public string DataNAscimento { set; FormMethod.Post; }
      
    }
    

   
}
