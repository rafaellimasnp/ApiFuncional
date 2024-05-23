using ApiFuncional.Data;
using Microsoft.EntityFrameworkCore;

namespace ApiFuncional.Configuration
{
    public static class DbContextConfig
    {
        public static WebApplicationBuilder AddDbContextConfig(this WebApplicationBuilder builder)
        {

            builder.Services.AddDbContext<ApiDbContext>(options =>
            {
                options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
                    new MySqlServerVersion(new Version(8, 3, 0))); // Ajuste a versão do MySQL conforme necessário
            });
            return builder;
        }
    }
}
