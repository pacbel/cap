using cap.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.Linq;

namespace cap.Configurations
{
    public class DBFactoryDBContext : IDbContextFactory<CapDBContext>
    {
        private readonly IConfiguration _configuration;

        public DBFactoryDBContext(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public CapDBContext CreateDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<CapDBContext>();
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
            CapDBContext contexto = new CapDBContext(optionsBuilder.Options);
            var migracoespendentes = contexto.Database.GetPendingMigrations();
            if (migracoespendentes.Count() > 0)
            {
                contexto.Database.Migrate();
            }
            return contexto;
        }
    }
}
