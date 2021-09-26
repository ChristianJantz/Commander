using AutoMapper;
using Commander.Models;
using Commander.Dtos;

namespace Commander.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            // Source -> Taget
            // From DataModel in DataTranferObject
            CreateMap<Command, CommandReadDto>();
            //if new Create DataTranferObject in DataModel
            CreateMap<CommandCreateDto, Command>();
            // if any Data is update from the DTO in DateModel
            CreateMap<CommandUpdateDto, Command>();
        }
    }
}