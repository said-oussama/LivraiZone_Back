using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class MovieRentalConfiguration : IEntityTypeConfiguration<MovieRental>
    {
        public void Configure(EntityTypeBuilder<MovieRental> builder)
        {
            // Configuration pour la clé composite (many-to-many)
            builder.HasKey(g => new { g.RentalId, g.MovieId });
        }
    }
}
