using System.Collections.Generic;
using System.Threading.Tasks;
using WEB_API.Models;

namespace WEB_API.Services.CharacterService
{
    public interface ICharacterService
    {
         Task<ServiceResponse<List<Character>>> GetAllCharacter();
         Task<ServiceResponse<Character>> GetCharacterById(int id);

         Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter);


    }
}