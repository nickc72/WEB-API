using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_API.Dtos.Character;
using WEB_API.Models;
using AutoMapper;
using System;

namespace WEB_API.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character {Id=1,Name ="Sam"}

        };
        private readonly IMapper _mapper;

        public CharacterService(IMapper mapper)
        {
            _mapper = mapper;

        }
        public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter)
        {
            var ServiceResponse = new ServiceResponse<List<GetCharacterDto>>();
            Character character=_mapper.Map<Character>(newCharacter);
            character.Id=characters.Max(c => c.Id)+1;
            characters.Add(character);
            ServiceResponse.Data = characters.Select(c =>_mapper.Map<GetCharacterDto>(c)).ToList();
            //return (characters);
            return ServiceResponse;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacter()
        {
            var ServiceResponse = new ServiceResponse<List<GetCharacterDto>>();
            ServiceResponse.Data = characters.Select(c =>_mapper.Map<GetCharacterDto>(c)).ToList();
            //return (characters);
            return ServiceResponse;
        }

        public async Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id)
        {
            var ServiceResponse = new ServiceResponse<GetCharacterDto>();
            ServiceResponse.Data = _mapper.Map<GetCharacterDto>(characters.FirstOrDefault(c => c.Id == id));
            return ServiceResponse;

        }

       
        public async Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter)
        {
            
            var serviceResponse = new ServiceResponse<GetCharacterDto>();
            try
            {   
                Character character = characters.FirstOrDefault(c => c.Id==updatedCharacter.Id);

                character.Name= updatedCharacter.Name;
                character.Defense=updatedCharacter.Defense;
                character.Intelligence=updatedCharacter.Intelligence;
                character.HitPoints=updatedCharacter.HitPoints;
                character.Class=updatedCharacter.Class;
                character.Strength=updatedCharacter.Strength;

                serviceResponse.Data=_mapper.Map<GetCharacterDto>(character);

                
            }
            catch(Exception ex)
            {
                serviceResponse.Success=false;
                serviceResponse.Message=ex.Message;
            } 
            return serviceResponse;
        }
    }
}