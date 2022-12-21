
using e_ticaret.DomainService;
using e_ticaret.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace e_ticaret
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
            }));
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "e_ticaret", Version = "v1" });
            });
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnetion")));

            services.AddScoped<IProductService, ProductService>();
            
            /* services.AddTransient<IProductCRUD, ProductCRUD>()*/


            //services.AddScoped<IRepositoryToy, RepositoryToy>();
            //services.AddScoped<IRepositoryElectronic, RepositoryElectronic>();
            //services.AddScoped<IRepositoryOutdoor, RepositoryOutdoor>();
            //services.AddScoped<IRepositoryDress, RepositoryDress>();
            //services.AddScoped<IRepositoryFridge, RepositoryFridge>();
            //services.AddScoped<IRepositoryPhone, RepositoryPhone>();
            //services.AddScoped<IRepositoryTv, RepositoryTv>();
            //services.AddScoped<IRepositoryComputer, RepositoryComputer>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "e_ticaret v1"));
            }


            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors(builder =>
           builder.AllowAnyOrigin()
           );

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
