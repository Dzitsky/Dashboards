using Dashboard.Application.AppServices.Contexts.Files.Repositories;
using Dashboard.Application.AppServices.Contexts.Files.Services;
using Dashboard.Application.AppServices.Contexts.Post.Repositories;
using Dashboard.Application.AppServices.Contexts.Post.Services;
using Dashboard.Contracts.Post;
using Dashboard.Hosts.Api.Controllers;
using Dashboard.Infrastructure.ComponentRegistrar;
using Dashboard.Infrastructure.DataAccess.Contexts.Files.Repositories;
using Dashboard.Infrastructure.DataAccess.Contexts.Post.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(s =>
{
    var includeDocsTypesMarkers = new[]
    {
        typeof(PostDto),
        typeof(PostController)
    };
            
    foreach (var marker in includeDocsTypesMarkers)
    {
        var xmlName = $"{marker.Assembly.GetName().Name}.xml";
        var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlName);
            
        if (File.Exists(xmlPath))
            s.IncludeXmlComments(xmlPath);
    }
});

builder.Services.ConfigureRepositories(builder.Configuration);

builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddScoped<IPostRepository, PostRepository>();
builder.Services.AddTransient<IFileService, FileService>();
builder.Services.AddTransient<IFileRepository, FileRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();