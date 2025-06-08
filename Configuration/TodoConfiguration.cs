using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TodoApps.Models;

namespace TodoApps.Configuration
{
 
    
        public class TodoConfiguration : IEntityTypeConfiguration<Todo>
        {
            public void Configure(EntityTypeBuilder<Todo> builder)
            {
                builder.Property(t => t.Name)
                    .IsRequired()
                    .HasMaxLength(30);
                builder.Property(t => t.Description)
                    .IsRequired(false)
                    .HasMaxLength(150);
            }
    }
}