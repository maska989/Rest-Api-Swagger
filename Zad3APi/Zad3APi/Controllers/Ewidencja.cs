using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Zad3APi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ewidencja : ControllerBase
    {

        private readonly ProgramMemory _memory;
        public Ewidencja(ProgramMemory memory)
        {

            _memory = memory;
        }

        // GET: api/<Ewidencja>
        [HttpGet]
        public Dictionary<Guid,Guid> Get()
        {
            return _memory.Ewidencja;
        }

        // GET api/<Ewidencja>/5
        [HttpGet("GetByOsoba/{id}")]
        public IEnumerable<KeyValuePair<Guid,Guid>> GetByOsoba(Guid id)
        {
      
                return _memory.Ewidencja.Where(e => e.Value.Equals(id));
            
          
        }
        // GET api/<Ewidencja>/6
        [HttpGet("GetByPokoj/{id}")]
        public KeyValuePair<Guid,Guid> GetByPokoj(Guid id)
        {

            if (_memory.Ewidencja.ContainsKey(id))
            {
                return _memory.Ewidencja.First(e => e.Key == id);
            }
            return new KeyValuePair<Guid, Guid> (id,Guid.Empty);
        }

        // POST api/<Ewidencja>
        [HttpPost("PostByPokoj")]
        public KeyValuePair<Guid,Guid> Post(Guid Pokoj,Guid Osoba)
        {
            KeyValuePair<Guid,Guid> kvp = new KeyValuePair<Guid,Guid>(Pokoj,Osoba);

            _memory.Ewidencja.Add(kvp.Key,kvp.Value);
            return kvp;
        }


        // DELETE api/<Ewidencja>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            if (_memory.Ewidencja.ContainsKey(id))
                _memory.Ewidencja.Remove(id);
        }
    }
}
