namespace AppServer.CustomerService.DataAccessLayer
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    public class CustomerContext : DbContext
    {
        private readonly string _connectionString;

        public CustomerContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CustomerContext>(options =>
                options.UseSqlServer(_connectionString));
        }

    }
}
