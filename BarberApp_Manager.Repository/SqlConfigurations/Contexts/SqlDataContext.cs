using BarberApp_Manager.Entity;
using BarberApp_Manager.Entity.Cabeleireiro;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Logging;

namespace BarberApp_Manager.Repository.SqlConfigurations.Contexts
{
    public class SqlDataContext : DbContext
    {
        private ILoggerFactory _loggerFactory { get; set; }

        public SqlDataContext()
        {
            _loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
        }

        public SqlDataContext(DbContextOptions options) : base(options)
        {
            _loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
        }

        internal static string? GetConnectionEnviroment()
        {
            return Environment.GetEnvironmentVariable("DefaultConnection") ?? Environment.GetEnvironmentVariable("DEFAULTCONNECTION");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string? connectionString = GetConnectionEnviroment();

                if (String.IsNullOrWhiteSpace(connectionString))
                {
                    optionsBuilder.UseSqlServer();
                }
                else
                {
                    optionsBuilder.UseSqlServer(connectionString);
                }
            }

#if DEBUG
            optionsBuilder.UseLoggerFactory(_loggerFactory);
#endif
        }

        public void ConfigureSave()
        {
            DateTime dhNow = DateTime.Now;

            foreach(EntityEntry entityEntry in this.ChangeTracker.Entries().Where(x => (x.State == EntityState.Modified || x.State == EntityState.Added) && x.Entity is DefaultEntityNoKey))
            {
                if(entityEntry.Entity is DefaultEntityNoKey defaultEntityNoKey)
                {
                    switch (entityEntry.State)
                    {
                        case EntityState.Added:
                            defaultEntityNoKey.DhInclusao = dhNow;
                            break;

                        case EntityState.Modified:
                            defaultEntityNoKey.DhAlteracao = dhNow;
                            break;
                    }
                }
            }
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            ConfigureSave();
            return base.SaveChangesAsync(cancellationToken);
        }

        public override int SaveChanges()
        {
            ConfigureSave();
            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SqlDataContext).Assembly);
        }

        public DbSet<CabeleireiroEntity> CabeleireiroEntity { get; set; }
    }
}
