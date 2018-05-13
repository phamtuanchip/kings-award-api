using AspNet5SQLite.Model;
using AspNet5SQLite.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.IO;
using Newtonsoft.Json.Serialization;

namespace AspNet5SQLite
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; set; }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("config.json");

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }
        
        public void ConfigureServices(IServiceCollection services)
        {
            var connection = Configuration["Production:SqliteConnectionString"];

            services.AddDbContext<DataEventRecordContext>(options =>
                options.UseSqlite(connection)
            );

            services.AddDbContext<KingsAwardDataBase>(options =>
               options.UseSqlite(connection)
           );


            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });

            services.AddMvc().AddJsonOptions(options =>
            {
                options.SerializerSettings.ContractResolver = new DefaultContractResolver();
            });
            services.AddScoped<IDataEventRecordRepository, DataEventRecordRepository>();

            services.AddScoped<IDataBase, DataBaseImpl>();
             
        }

         public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();
            loggerFactory.AddDebug();

            var locOptions = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>();
            app.UseRequestLocalization(locOptions.Value);

            app.UseStaticFiles();
            app.UseCors("CorsPolicy");
            // app.UseCors(builder =>
            //    builder.WithOrigins("http://localhost")
            //.AllowAnyHeader()
            //  );
            app.UseMvc();
            
            // Shows UseCors with CorsPolicyBuilder.

        }
    }
}
