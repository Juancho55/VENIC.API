using Infra;
using Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using VENIC.API.WEB.Extensions;

namespace VENIC.API.WEB
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "VENIC.API", Version = "V1" });
                c.CustomSchemaIds(ShemaIdStrategy);
                c.OperationFilter<CustomFilters.AddHeaderFilter>();
            });
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });
            services.AddMvc();
            services.AddInfraestructure(Configuration);
            services.AddServices(Configuration);
        }

        private string ShemaIdStrategy(Type currentClass)
        {
            return currentClass.Name.EndsWith("Model") ? currentClass.Name.Replace("Model", string.Empty) : currentClass.Name;
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseCors();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("./swagger/v1/swagger.json", "VENIC.API");
                c.InjectStylesheet("./swagger-ui/custom.css");
                c.RoutePrefix = string.Empty;
            });
        }
    }
}
