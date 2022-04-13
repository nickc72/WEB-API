using AutoMapper;
using WEB_API.Dtos.Character;
using WEB_API.Models;

namespace WEB_API
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character,GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }
    }
}