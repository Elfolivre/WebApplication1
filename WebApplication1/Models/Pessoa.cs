using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace WebApplication1.Controller

{
 [HttpPost]
    public class Pessoa
    {
     [Route("receber/{id;string}")]
      public int Id { set;}
     
     [Route("receber/{Nome;string}")]
        public string Nome { set;}
     
     [Route("receber/{DataNascimento;string}")]
        public string DataNAscimento { set; }
      
    }
    

   
}
