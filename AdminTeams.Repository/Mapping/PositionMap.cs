using AdminTeams.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdminTeams.Repository.Mapping
{
    public class PositionMap : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.ToTable("Position");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(prop => prop.Acronym)
                .IsRequired()
                .HasMaxLength(10);
        }
    }
}