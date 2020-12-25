using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WebApiExample.Models;

namespace WebApiExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private List<Person> _people = new List<Person>();

        public PersonController()
        {
            _people.Add(new Person() { Id = 1, FirstName = "James", LastName = "Sprayberry" });
            _people.Add(new Person() { Id = 2, FirstName = "Jason", LastName = "Mosley" });
            _people.Add(new Person() { Id = 3, FirstName = "Jennifer", LastName = "Dietz" });
            _people.Add(new Person() { Id = 4, FirstName = "Bessie", LastName = "Duppstadt" });
        }

        [HttpGet]
        public List<Person> GetAll()
        {
            return _people;
        }
        [HttpGet("{id}")]
        public ActionResult<Person> GetPersonById(int id)
        {
            var person = _people.FirstOrDefault(p => p.Id == id);

            if (person == null)
            {
                return NotFound();
            }

            return person;
        }

        [HttpGet("GetPById/{id}")]
        public IActionResult GetPById(int id)
        {
            string json = default;
            var person = _people.FirstOrDefault(p => p.Id == id);
            if (person != null)
                json = JsonSerializer.Serialize(person);
            else
                json = "{\"Id\":" + id + "}, \"FirstName\":\"NOT FOUND\"}";
            return Ok(json);
        }

        [HttpGet("GetPersonByID/{id}")]
        [Produces("application/xml")]
        public ActionResult<Person> GetPersonByID(int id)
        {
            var person = _people.FirstOrDefault(p => p.Id == id);
            if (person != null)
                return NotFound();
            return (person);
        }

    }
}
