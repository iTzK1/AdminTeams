using AdminTeams.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdminTeams.Repository.Mapping
{
    public class PlayerMap : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.ToTable("Player");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(prop => prop.BirthDate)
                .IsRequired();

            builder.Property(prop => prop.ShirtNumber)
                .IsRequired();

          
            builder.HasOne(prop => prop.Team)
                .WithMany()
                .HasForeignKey(prop => prop.TeamId)
                .OnDelete(DeleteBehavior.Cascade);

          
            builder.HasOne(prop => prop.Position)
                .WithMany()
                .HasForeignKey(prop => prop.PositionId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}