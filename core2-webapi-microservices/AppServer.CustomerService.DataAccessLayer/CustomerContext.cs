using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AppServer.CustomerService.DataAccessLayer
{
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
