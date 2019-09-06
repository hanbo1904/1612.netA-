using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalScheds.Model;
using HospitalScheds.IServerce;
using HospitalScheds.Serverce;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace HospitalScheds
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        public IConfiguration Configuration { get; }


        // This method gets called by the runtime. Use this method to add services to the container.王龙宇提交
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            //services.AddScoped<IAnnouncementformServerce,AnnouncementformServerce>();


            //注册跨域服务，允许所有来源
            services.AddCors(options =>
                options.AddPolicy("AllowAnyCors",
                p => p.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin().AllowCredentials().AllowAnyOrigin())
            );
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }




            //允许跨域访问
            app.UseCors("AllowAnyCors");
            app.UseHttpsRedirection();
            app.UseMvc();


        }
    }
}
