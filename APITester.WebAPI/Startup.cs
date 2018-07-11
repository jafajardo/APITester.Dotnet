using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APITester.Business.Interface;
using APITester.Business.Service;
using APITester.DataAccess.Interface;
using APITester.DataAccess.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Autofac;
using Autofac.Configuration;
using Autofac.Extensions.DependencyInjection;

namespace APITester.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CORSPolicy",
                    builder =>
                    {
                        builder.AllowAnyHeader()
                            .AllowAnyMethod()
                            .AllowAnyOrigin();
                    });
            });

            services.AddMvc();

            var container = ConfigureAutofacInstance(services);
            return new AutofacServiceProvider(container);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors("CORSPolicy");
            app.UseMvc();
        }

        private IContainer ConfigureAutofacInstance(IServiceCollection services)
        {
            //var config = new ConfigurationBuilder();
            //config.AddJsonFile("autofac.json");

            //var module = new ConfigurationModule(config.Build());
            var container = new ContainerBuilder();

            container.RegisterType<APITesterDataService>().As<IAPITesterDataService>().InstancePerDependency()
                .WithParameter("dbServiceLocator",
                    new DBServiceLocator("Data Source=localhost;Initial Catalog=APITester;Integrated Security=True"));
            container.RegisterType<APITesterBusinessService>().As<IAPITesterBusinessService>().InstancePerDependency();
            //container.RegisterModule(module);

            container.Populate(services);

            return container.Build();
        }
    }
}
