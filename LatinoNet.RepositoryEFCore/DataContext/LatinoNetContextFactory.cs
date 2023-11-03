using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace LatinoNet.RepositoryEFCore.DataContext
{
    public class LatinoNetContextFactory  : IDesignTimeDbContextFactory<LatinoNetContext>
    {
        public LatinoNetContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LatinoNetContext>();

            optionsBuilder.UseSqlServer(
                "Server=localhost;Database=LatinoNet2;TrustServerCertificate=True;Trusted_Connection=true;MultipleActiveResultSets=true");
            return new LatinoNetContext(optionsBuilder.Options);
            
            
                
        }
    }
}