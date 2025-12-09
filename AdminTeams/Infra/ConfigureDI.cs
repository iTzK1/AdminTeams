using AutoMapper;
using AdminTeams.Domain.Base;
using AdminTeams.Domain.Entities;
using AdminTeams.Repository.Context;
using AdminTeams.Repository.Repository;
using AdminTeams.Service.Service;
using AdminTeams.App.Models; 
using AdminTeams.App.Forms; 
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;

namespace AdminTeams.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection Services;
        public static IServiceProvider ServicesProvider;

        public static void ConfigureServices()
        {
            Services = new ServiceCollection();


            // 1. Database Configuration
            // Replace with your actual connection string or file reader logic
            var connectionString = "Server=localhost;Port=3306;Database=AdminTimesDB;Uid=root;Pwd=;"; // mantenha se for o nome do DB
            Services.AddDbContext<AdminTeamsContext>(options =>
            {
                options.UseMySQL(connectionString);
                options.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
            });

            // 2. Repositories Injection
            Services.AddScoped<IBaseRepository<Team>, BaseRepository<Team>>();
            Services.AddScoped<IBaseRepository<Position>, BaseRepository<Position>>();
            Services.AddScoped<IBaseRepository<Player>, BaseRepository<Player>>();

            // 3. Services Injection
            Services.AddScoped<IBaseService<Team>, BaseService<Team>>();
            Services.AddScoped<IBaseService<Position>, BaseService<Position>>();
            Services.AddScoped<IBaseService<Player>, BaseService<Player>>();

            // 4. Forms Injection (We will add these classes in the next steps)
            Services.AddTransient<TeamForm>();
            Services.AddTransient<PositionForm>();
            Services.AddTransient<PlayerForm>();
            Services.AddSingleton<MainForm>(); // Register MainForm

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Team, TeamViewModel>();
                cfg.CreateMap<Position, PositionViewModel>();

                cfg.CreateMap<Player, PlayerViewModel>()
                    .ForMember(d => d.Team, opt => opt.MapFrom(src => src.Team.Name))
                    .ForMember(d => d.Position, opt => opt.MapFrom(src => src.Position.Name))
                    .ForMember(d => d.BirthDate, opt => opt.MapFrom(src => src.BirthDate.ToShortDateString()));
            });

            Services.AddSingleton(config.CreateMapper());

            // Build Provider
            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}