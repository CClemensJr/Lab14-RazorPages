using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetAGram.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using DotNetAGram.Models.Services;
using DotNetAGram.Models.Interfaces;

namespace DotNetAGram
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        /// <summary>
        /// This custom constructor allows for facilitation of IConfiguration interface
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            //services.AddDbContext<DotNetAGramDbContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));
            services.AddDbContext<DotNetAGramDbContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:ProductionConnection"]));

            services.AddScoped<IPost, PostService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline. 
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            app.UseStaticFiles();
        }
    }
}
