using Airport.Implementation;
using AirPort.DataAccess;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutoMapper.Configuration;
using Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Airport
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().AddJsonOptions(options =>
            {
                options.SerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
            });
            services.AddCors();

            var builder = new ContainerBuilder();

            builder.RegisterModule<InfrastructureModule>();
            builder.RegisterModule<ImplementationModule>();
            builder.RegisterModule<DataAccessModule>();

            var container = builder.Build();

            return new AutofacServiceProvider(container);
        }

        public IConfiguration Configuration { get; }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseMvc();
        }
    }
}
