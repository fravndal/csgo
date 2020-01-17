namespace Api
{
    using Api.GraphQL;
    using Core.Interfaces;
    using global::GraphQL;
    using global::GraphQL.Server;
    using global::GraphQL.Server.Ui.Playground;
    using Infrastructure.SQL;
    using Infrastructure.SQL.Repository;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        readonly string MyAllowSpecificOrigins = "_myAllowSpcificOrigins";

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(o => o.AddPolicy(MyAllowSpecificOrigins, builder =>
            {
                builder.WithOrigins("https://localhost:5001/graphql", "http://localhost:3000").AllowAnyHeader().AllowAnyMethod();
            }));

            services.AddScoped<IDependencyResolver>(s => new FuncDependencyResolver(s.GetRequiredService));
            services.AddScoped<CSGOSchema>();
            services.AddGraphQL(o => { o.ExposeExceptions = true; }).AddGraphTypes(ServiceLifetime.Scoped);

            //register the DbContext
            services.AddDbContext<SqlContext>(o => o.UseSqlServer(Configuration.GetConnectionString("csgo")));

            // register the repository
            services.AddScoped<IRepository, SqlRepository>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseCors(MyAllowSpecificOrigins);
            app.UseGraphQL<CSGOSchema>();
            app.UseGraphQLPlayground(new GraphQLPlaygroundOptions());
        }
    }
}
