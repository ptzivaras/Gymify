using GymifyAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace GymifyAPI.Data
{
    // Αυτή η κλάση λέει στα EF tools πώς να φτιάξουν το DbContext
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            // Βάλε εδώ το ίδιο connection string με το appsettings.json
            optionsBuilder.UseSqlServer(
                "Server=localhost;Database=GymifyDb;Trusted_Connection=True;TrustServerCertificate=True;");

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
