﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class Pessoa
    {
     
        public int Id { FormMethod.Post; set; }
        
        
        public string Nome { FormMethod.Post; set; }
        public string DataNAscimento { FormMethod.Post; set; }
      
    }
}
