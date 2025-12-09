using AdminTeams.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdminTeams.Repository.Mapping
{
    public class TeamMap : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.ToTable("Team");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(prop => prop.Category)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}