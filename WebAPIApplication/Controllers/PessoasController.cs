using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebAPIApplication.Controllers
{
    [Route("api/pessoas")]
    public class PessoasController : Controller
    {
        private List<string> _dados;
        readonly DataContext _dbContext;

        public PessoasController (DataContext dbContext)
        {
            _dbContext = dbContext;
            // IniciarDados();
        }
        // GET api/Pessoas
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var pessoas = await _dbContext.Pessoas.ToListAsync();
            return Json(pessoas);
        }

        // GET api/Pessoas/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/Pessoas
        [HttpPost]
        public void Post([FromBody]string value)
        {
            IniciarDados();
            _dados.Add(value);
        }

        // PUT api/Pessoas/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/Pessoas/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        protected void IniciarDados()
        {
            _dados = new List<string>();
            _dados.Add("Jeferson");
            _dados.Add("Fracalossi");
        }
    }
}
