using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[Controller]/[Action]")]
    [ApiController]
    public class PessoasController : Controller
    {
        private BancoDados _db = new BancoDados();

        [HttpGet("{Id}")]
        public ActionResult Get(int id)
        {
            return Ok(Set_Dados.First(x => x.Id == id));
        }

        [HttpPost()]
        public ActionResult Listar([FromBody] Pagging pagging)
        {
            return Ok();
        }

        [HttpPost()]
        public ActionResult CriarAtualizar([FromBody] Pessoa pagging)
        {
            
        }

        [HttpDelete("{Id}")]
        public ActionResult Delete(int id)
        {

        }

    }
}
