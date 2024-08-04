using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using uService.Database;
using uService.Services;

namespace uService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var configuration = builder.Configuration;

            builder.Services.AddDbContext<AppDbContext>(options => options.UseLazyLoadingProxies().UseSqlite(configuration.GetConnectionString("DefaultConnection")));


            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddTransient<IOrderService, OrderService>();

            builder.Services.AddSwaggerGen(swagger =>
            {
                swagger.SwaggerDoc("v1", new OpenApiInfo { Title = "Vzorova uSluzba pro Alzu", Version = "v1" });

            });

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}