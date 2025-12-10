using AdminTeams.App.Forms;  // Você precisa criar esta pasta e os Forms dentro
using AdminTeams.App.Models; // Você precisa criar esta pasta e as classes dentro
using AdminTeams.Domain.Base;
using AdminTeams.Domain.Entities;
using AdminTeams.Repository.Context;
using AdminTeams.Repository.Repository;
using AdminTeams.Service.Service;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System;

namespace AdminTeams.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;
        public static IServiceProvider? ServicesProvider;

        public static void ConfigureServices()
        {
            Services = new ServiceCollection();

            // 1. Configuração do Banco de Dados
            var connectionString = "Server=localhost;Port=3306;Database=AdminTeamsDB;Uid=root;Pwd=;";

            Services.AddDbContext<AdminTeamsContext>(options =>
            {
      
                options.UseMySQL(connectionString);
                options.LogTo(Console.WriteLine, LogLevel.Information);
            });

            // 2. Injeção dos Repositórios (Generic Repository)
            Services.AddScoped<IBaseRepository<Team>, BaseRepository<Team>>();
            Services.AddScoped<IBaseRepository<Position>, BaseRepository<Position>>();
            Services.AddScoped<IBaseRepository<Player>, BaseRepository<Player>>();

            // 3. Injeção dos Serviços (Generic Service)
            Services.AddScoped<IBaseService<Team>, BaseService<Team>>();
            Services.AddScoped<IBaseService<Position>, BaseService<Position>>();
            Services.AddScoped<IBaseService<Player>, BaseService<Player>>();

            // 4. Injeção dos Forms (Você precisa criar estes arquivos no projeto App)
            Services.AddTransient<TeamForm>();
            Services.AddTransient<PositionForm>();
            Services.AddTransient<PlayerForm>();
            Services.AddSingleton<MainForm>();

            // 5. Configuração do AutoMapper
            // Registra profiles automaticamente — requer AutoMapper.Extensions.Microsoft.DependencyInjection
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Team, TeamViewModel>();
                config.CreateMap<Position, PositionViewModel>();

                config.CreateMap<Player, PlayerViewModel>()
                    .ForMember(d => d.Team, opt => opt.MapFrom(src => src.Team.Name))
                    .ForMember(d => d.Position, opt => opt.MapFrom(src => src.Position.Name))
                    .ForMember(d => d.BirthDate, opt => opt.MapFrom(src => src.BirthDate.ToShortDateString()));
            }, NullLoggerFactory.Instance).CreateMapper());

            // Constrói o Provider
            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}