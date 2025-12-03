using LVK.Bootstrapping;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Bootstrap(new ApplicationBootstrapper());

WebApplication app = builder.Build();
await app.Initialize();
await app.RunAsync();