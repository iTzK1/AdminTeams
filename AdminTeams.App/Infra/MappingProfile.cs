using AutoMapper;
using AdminTeams.Domain.Entities;
using AdminTeams.App.Models;

namespace AdminTeams.App.Infra
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Mapeamentos (Requer que as classes ViewModel existam na pasta Models)
            CreateMap<Team, TeamViewModel>();
            CreateMap<Position, PositionViewModel>();

            CreateMap<Player, PlayerViewModel>()
                .ForMember(d => d.Team, opt => opt.MapFrom(src => src.Team.Name))
                .ForMember(d => d.Position, opt => opt.MapFrom(src => src.Position.Name))
                .ForMember(d => d.BirthDate, opt => opt.MapFrom(src => src.BirthDate.ToShortDateString()));
        }
    }
}