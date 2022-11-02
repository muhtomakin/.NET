using AutoMapper;
using WebApi.Entities;
using WebApi.Application.ActorOperations.Queries.GetActors;

namespace WebApi.Common;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Actor, ActorsViewModel>();
    }
}