using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using ContosoCrafts.Models;
using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ContosoCrafts
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // Advertises the services available to the host
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            
            // Add new service for controller
            services.AddControllers();

            // Add a new service to read JSON file - transient means the service comes and goes
            services.AddTransient<JsonFileProductService>();

            // Add a new service for Razor Components
            services.AddServerSideBlazor();
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            // Endpoints Mapping 
            app.UseEndpoints(endpoints =>
            {
                // Standard endpoint mapping for webpages inside Pages
                // E.g. /index.html and /privacy.html and /error.html
                endpoints.MapRazorPages();
                // Add endpoint for controller - refer to ProductsController.cs
                endpoints.MapControllers();

                // Add an endpoint for razor components
                endpoints.MapBlazorHub();


                // Old Way to create Web API
                // Create Mapping for JSON Endpoint
                // Get request to /products
                //endpoints.MapGet("/products", (context) =>
                //{
                //    var products = app.ApplicationServices.GetService<JsonFileProductService>().GetProducts();
                //    var json = JsonSerializer.Serialize<IEnumerable<Product>>(products);
                //    return context.Response.WriteAsync(json);
                //});
            });
        }
    }
}
