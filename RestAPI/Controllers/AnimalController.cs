using Microsoft.AspNetCore.Mvc;
using RestAPI.Models;
using RestAPI.Service;

namespace RestAPI.Controllers
{
    [Route("/api/Animal")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private AnimalService _service;
        AnimalController(AnimalService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.getAll());

        }
        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            return Ok(_service.get(id));

        }
        [HttpPost]
        public IActionResult post([FromBody]Animal animal)
        {
            _service.add(animal);
            return StatusCode(StatusCodes.Status201Created);
        }
        [HttpPut("{id:int}")]
        public IActionResult put(int id, [FromBody]Animal animal)
        {
            _service.update(id, animal);
            return NoContent();

        }
        [HttpDelete("{id:int}")]
        public IActionResult delete(int id) { 
            _service.delete(id);
            return NoContent();
        } 
    }
}
