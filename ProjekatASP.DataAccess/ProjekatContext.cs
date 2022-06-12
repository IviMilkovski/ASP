using ProjekatASP.DataAccess.Configurations;
using ProjekatASP.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace ProjekatASP.DataAccess
{
    public class ProjekatContext : DbContext
    {
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);

            modelBuilder.Entity<PostComment>().HasKey(x => new { x.PostId, x.CommentId });
            modelBuilder.Entity<UserUseCase>().HasKey(x => new { x.UserId, x.UseCaseId });
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                if (entry.Entity is Entity e)
                {
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            e.IsActive = true;
                            e.CreatedAt = DateTime.UtcNow;
                            e.IsDeleted = false;
                            e.DeletedAt = null;
                            e.UpdatedAt = null;
                            break;
                        case EntityState.Modified:
                            e.UpdatedAt = DateTime.UtcNow;
                            e.UpdatedBy = null;
                            break;
                    }
                }
            }
            return base.SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = DESKTOP-5U9ROR3\SQLEXPRESS01; Initial Catalog = ASPblog; Integrated Security = True");
        }


        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<PostComment> PostComments { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<UserUseCase> UserUseCases { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }
    }
}
