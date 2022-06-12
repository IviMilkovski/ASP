using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjekatASP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatASP.DataAccess.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
        

            builder.Property(c => c.Text).IsRequired()
                .HasMaxLength(255);

            builder.Property(c => c.UserId).IsRequired();

            builder.HasMany(c => c.CommentPosts)
                .WithOne(cp => cp.Comment)
                .HasForeignKey(cp => cp.CommentId)
                .OnDelete(DeleteBehavior.Cascade);

            
        }
    }
}
