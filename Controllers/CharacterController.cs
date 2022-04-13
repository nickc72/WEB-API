using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WEB_API.Dtos.Character;
using WEB_API.Models;
using WEB_API.Services.CharacterService;

namespace WEB_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        /* Removed because of dependency injection
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character {Id=1,Name ="Sam"}
        

    };
    */
    private readonly ICharacterService _characterService;
    public CharacterController(ICharacterService characterService)     //Dependency Injection
    {
        _characterService = characterService;

    }

    //[HttpGet]
    //[Route("GetAll")]
    [HttpGet("GetAll")]
    public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> Get()
    {
        //return Ok(characters);
        return Ok( await _characterService.GetAllCharacter());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> GetSingle(int id)
    {
        //return Ok(characters.FirstOrDefault(c => c.Id == id));
        return Ok(await _characterService.GetCharacterById(id));
    }

    [HttpPost]

    public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> AddCharacter(AddCharacterDto newCharacter)
    {
        //characters.Add(newCharacter);
        //return Ok(characters);
        return Ok(await _characterService.AddCharacter(newCharacter));
    }

    [HttpPut]
    public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> UpdateCharacter(UpdateCharacterDto updatedCharacter)
    {
        var response = await _characterService.UpdateCharacter(updatedCharacter);
        if(response.Data==null)
        {
            return NotFound(response);
        }
        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> Delete(int id)
    {
        
        var response = await _characterService.DeleteCharacter(id);
        if(response.Data==null)
        {
            return NotFound(response);
        }
        return Ok(response);
    }
}

    
}