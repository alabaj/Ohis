using AutoMapper;
using Ohis.DataContext.Entities;
using Ohis.Library.Domain;

namespace Ohis.DataContext.Mappings;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<ClientEntity, ClientModel>().ReverseMap();
		CreateMap<TicketEntity, TicketModel>().ReverseMap();
	}
}
