using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIApplication.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private List<string> _dados;

        public ValuesController ()
        {
          IniciarDados();
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return _dados;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            IniciarDados();
            _dados.Add(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
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
