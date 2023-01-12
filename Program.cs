using FinalEgzam.Database;
using FinalEgzam.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var allowAll = "_allowAll";
#region
builder.Services.AddScoped<IPersonRepository, PersonRepository>();
builder.Services.AddScoped<IResidenceRepository, ResidenceRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddDbContext<ApplicationDbContext>
    (options => options.UseSqlServer
    (builder.Configuration.GetConnectionString
    ("Database")));
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: allowAll,
                      build =>
                      {
                          build.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                      });
});
#endregion





var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(allowAll);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
