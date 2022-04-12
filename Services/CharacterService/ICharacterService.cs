using System.Collections.Generic;
using WEB_API.Models;

namespace WEB_API.Services.CharacterService
{
    public interface ICharacterService
    {
         List<Character> GetAllCharacter();
         Character GetCharacterById(int id);
         List<Character> AddCharacter(Character newCharacter);


    }
}