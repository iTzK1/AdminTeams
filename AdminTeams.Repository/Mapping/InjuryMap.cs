using AdminTeams.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdminTeams.Repository.Mapping
{
    public class InjuryMap : IEntityTypeConfiguration<Injury>
    {
        public void Configure(EntityTypeBuilder<Injury> builder)
        {
            builder.ToTable("Injury");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Description)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(prop => prop.StartDate)
                .IsRequired();

            builder.Property(prop => prop.EndDate)
                .IsRequired(false); 

            // Relacionamento com Player
            builder.HasOne(prop => prop.Player)
                .WithMany()
                .HasForeignKey(prop => prop.PlayerId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}