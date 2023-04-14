using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ARCollaboration.Models;

public partial class CoreDbContext : DbContext
{
    public IConfiguration Configuration { get; }
    public CoreDbContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public CoreDbContext(DbContextOptions<CoreDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TemplateDetail> TemplateDetails { get; set; }

    public virtual DbSet<UserInformation> UserInformations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(Configuration.GetConnectionString("ARCollaboratorCon"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TemplateDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Template__3214EC077873BF41");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
