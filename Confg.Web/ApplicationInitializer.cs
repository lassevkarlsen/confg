using Confg.Web.Components;

using LVK.Bootstrapping;

namespace Confg.Web;

public class ApplicationInitializer : IHostInitializer<WebApplication>
{
    public Task InitializeAsync(WebApplication host)
    {
        // Configure the HTTP request pipeline.
        if (!host.Environment.IsDevelopment())
        {
            host.UseExceptionHandler("/Error", createScopeForErrors: true);
        }

        host.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
        host.UseAntiforgery();

        host.MapStaticAssets();
        host.MapRazorComponents<App>().AddInteractiveServerRenderMode();

        return Task.CompletedTask;
    }
}