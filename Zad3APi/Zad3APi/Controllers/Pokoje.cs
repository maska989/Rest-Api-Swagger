using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Zad3APi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Pokoje : ControllerBase
    {
        private readonly ProgramMemory _memory;
        public Pokoje(ProgramMemory memory)
        {

            _memory = memory;
        }

        // GET: api/<Pokoje>
        [HttpGet]
        public Dictionary<Guid, string> Get()
        {
            return _memory.Pokoje;
        }

        // POST api/<Pokoje>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            _memory.Pokoje.Add(Guid.NewGuid(), value);

        }

        // PUT api/<Pokoje>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] string value)
        {
            if (_memory.Pokoje.ContainsKey(id))
                _memory.Pokoje[id] = value;
        }

        // DELETE api/<Pokoje>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            if (_memory.Pokoje.ContainsKey(id))
                _memory.Pokoje.Remove(id);
        }
    }
}
