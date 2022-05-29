using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Zad3APi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]



    public class Osoby : ControllerBase
    {
        private readonly ProgramMemory _memory;
        public Osoby(ProgramMemory memory)
        {

            _memory = memory;
        }

        // GET: api/<Osoby>
        [HttpGet]
        public Dictionary<Guid,string> Get()
        {
            return _memory.Osoby;
        }

        // POST api/<Osoby>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            _memory.Osoby.Add(Guid.NewGuid(),value);

        }

        // PUT api/<Osoby>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] string value)
        {
            if (_memory.Osoby.ContainsKey(id))
                _memory.Osoby[id] = value;
        }

        // DELETE api/<Osoby>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            if(_memory.Osoby.ContainsKey(id))
                _memory.Osoby.Remove(id);
        }
    }
}
