

using PracticeAPI.Entities;
using Microsoft.OpenApi.Models;
using System.Text;
using PracticeAPI.Repositories;

namespace PracticeAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddTransient<IUserRepository, UserRepository>();
            builder.Services.AddTransient<IOrderRepossitory, OrderRepository>();
            builder.Services.AddTransient<IProductRepository, ProductRepository>();
            builder.Services.AddDbContext<MyContext>();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Practice API", Version = "v1" });
            });
            //enable cors
            builder.Services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options =>
       options.AllowAnyOrigin() //allows any client url
                .AllowAnyMethod() //allows all http methods like(get,post,put and delete)
                .AllowAnyHeader() //all any header like request,response and so on
                );
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseCors("AllowOrigin");
            app.UseAuthentication();  //add Authentication Middleware to the Application
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
