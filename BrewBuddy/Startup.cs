// <copyright file="Startup.cs" company="Mark Linton">
// Copyright (c) Mark Linton. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3 license.
// See LICENSE file in the solution root for full license information.
// </copyright>

namespace BrewBuddy
{
    using BrewBuddy.Data.Batches;
    using BrewBuddy.Data.Ingredients;
    using BrewBuddy.Data.Inventory;
    using BrewBuddy.Data.Persistence;
    using BrewBuddy.Data.Profiles.Equipment;
    using BrewBuddy.Data.Profiles.Fermentation;
    using BrewBuddy.Data.Profiles.Water;
    using BrewBuddy.Data.Recipes;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.HttpsPolicy;
    using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;

    /// <summary>
    /// Created when the application is instantiated.
    /// </summary>
    public class Startup
    {
        private SQLiteRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="Startup"/> class.
        /// </summary>
        /// <param name="configuration">Provides access to configuration.</param>
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
            this.repository = new SQLiteRepository();
        }

        /// <summary>
        /// Gets the application configuration.
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        /// <param name="services">Allows populating the IoC container.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddSingleton<IBatchesRepository>(this.repository)
                .AddSingleton<IIngredientsRepository>(this.repository)
                .AddSingleton<IInventoryRepository>(this.repository)
                .AddSingleton<IProfilesRepository>(this.repository)
                .AddSingleton<IRecipeRepository>(this.repository);

            services
                .AddTransient<IBatchService, BatchService>()
                .AddTransient<IEquipmentProfilesService, EquipmentProfilesService>()
                .AddTransient<IFermentationProfilesService, FermentationProfilesService>()
                .AddTransient<IIngredientService, IngredientService>()
                .AddTransient<IInventoryService, InventoryService>()
                .AddTransient<IRecipesService, RecipesService>()
                .AddTransient<IWaterProfilesService, WaterProfilesService>();

            services.AddControllersWithViews();

            // In production, the React files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/build";
            });
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app">Provides access to the IApplicationBuilder.</param>
        /// <param name="env">Provides access to the IWebHostEnvironment.</param>
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
            app.UseSpaStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer(npmScript: "start");
                }
            });
        }
    }
}
