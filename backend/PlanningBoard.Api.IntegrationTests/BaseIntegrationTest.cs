using System;
using System.Net.Http;

using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.EntityFrameworkCore;
//using Microsoft.Data.Sqlite;

using Api.Data.Contexts;

namespace Api.Tests
{

    public class BaseIntegrationTest// : IDisposable
    {
        private readonly HttpClient _client;
        private const string InMemoryConnectionString = "DataSource=:memory:";
        //private readonly SqliteConnection _connection;
        protected BaseIntegrationTest()
        {
            //_connection = new SqliteConnection(InMemoryConnectionString);
            var appFactory = new WebApplicationFactory<Startup>()
                            .WithWebHostBuilder(builder =>
                                    builder.ConfigureServices(
                                        services =>
                                        {
                                            services.RemoveAll(typeof(AppDbContext));
                                            services.AddDbContext<AppDbContext>(
                                                //options => options.UseSqlite(_connection)
                                                options => options.UseInMemoryDatabase("InMemoryDbForTesting")
                                            );
                                        }
                                    )
                                );
            _client = appFactory.CreateClient();

        }

        protected HttpClient GetClient()
        {
            return _client;
        }


        // public void Dispose()
        // {
        //     _connection.Close();
        // }


    }
}