// <copyright file="Startup.cs" company="Teqniqly">
// Copyright (c) Teqniqly. All rights reserved.
// </copyright>

namespace GraphQL
{
    using GraphQL.Data;
    using GraphQL.DataLoader;
    using GraphQL.Speakers;
    using GraphQL.Types;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;

    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddPooledDbContextFactory<ApplicationDbContext>(options =>
                    options.UseSqlServer(
                        this.configuration.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value,
                        builder => builder.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName))
                        .EnableDetailedErrors()
                        .EnableSensitiveDataLogging());

            services
                .AddGraphQLServer()
                .AddQueryType<Query>()
                .AddMutationType(d => d.Name("Mutation"))
                .AddTypeExtension<SpeakerMutations>()
                .AddType<SpeakerType>()
                .EnableRelaySupport()
                .AddDataLoader<SpeakerByIdDataLoader>()
                .AddDataLoader<SessionByIdDataLoader>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL();
            });
        }
    }
}
