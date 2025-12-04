var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Confg_Core>("confg-core");

builder.AddProject<Projects.Confg_Web>("confg-web");

builder.Build().Run();
