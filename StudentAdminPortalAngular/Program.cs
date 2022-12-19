using Microsoft.EntityFrameworkCore;
using StudentAdminPortalAngular.DataModels;
using StudentAdminPortalAngular.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<StudentAdminContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseConnection")));

builder.Services.AddScoped<IStudentRepository, StudentRepository>();

builder.Services.AddCors( (options)=> options.AddPolicy("AngularApplication", (builder) => {

    builder.WithOrigins("https://localhost:7028").AllowAnyHeader().WithMethods("GET", "POST", "PUT", "DELETE").WithExposedHeaders("*").AllowAnyOrigin();
})  ); 

builder.Services.AddAutoMapper(typeof(Program).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AngularApplication");

app.UseAuthorization();

app.MapControllers();

app.Run();
