using Confg.Web;

using LVK.Bootstrapping;

using Microsoft.AspNetCore.DataProtection;

public class ApplicationBootstrapper : IModuleBootstrapper
{
    public void Bootstrap(IHostApplicationBuilder builder)
    {
        builder.AddServiceDefaults();

        // Add services to the container.
        builder.Services.AddRazorComponents().AddInteractiveServerComponents();
        builder.Services.AddDataProtection()
           .PersistKeysToFileSystem(new DirectoryInfo("/data/dp-keys"))
           .SetApplicationName("Confg.Web");

        builder.Services.AddTransient<IHostInitializer<WebApplication>, ApplicationInitializer>();
    }
}