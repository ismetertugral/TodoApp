using System.IO;
using coldplayz.TodoAppNTier.Business.DependencyResolvers.Microsoft;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDependencies();
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles(new StaticFileOptions{
    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "node_modules")),
    RequestPath = "/node_modules"
});

app.UseRouting();

app.MapDefaultControllerRoute();

app.Run();
