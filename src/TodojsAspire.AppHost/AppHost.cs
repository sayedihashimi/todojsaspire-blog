var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.TodojsAspire_ApiService>("apiservice")
    .WithHttpHealthCheck("/health");

builder.Build().Run();
