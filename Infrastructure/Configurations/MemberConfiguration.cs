using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Infrastructure.Configurations
{
    public class MemberConfiguration : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {


            //one to many (Member and Rentals)

            builder.HasOne(s => s.Rental)
                .WithMany(r => r.Members)
                .HasForeignKey(s => s.RentalId);
        }
    }
}
