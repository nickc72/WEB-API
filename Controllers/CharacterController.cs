using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WEB_API.Models;

namespace WEB_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character {Id=1,Name ="Sam"}

        };


        //[HttpGet]
        //[Route("GetAll")]
        [HttpGet("GetAll")]
        public ActionResult <List<Character>> Get()
        {
        return Ok(characters);
        }

        [HttpGet("{id}")]
        public ActionResult <Character> GetSingle(int id){
            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }

        [HttpPost]

        public ActionResult <List<Character>> AddCharacter(Character newCharacter){
            characters.Add(newCharacter);
            return Ok(characters);
        }
    }

    
}