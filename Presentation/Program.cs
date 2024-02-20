using Application;
using Infrastructure;
using Application.Interfaces;
using Application.Services;
using Infrastructure.Repository;
var builder = WebApplication.CreateBuilder(args);
//register configuration
ConfigurationManager configuration = builder.Configuration ;

//builder.Services.AddSqlServer<MemberContext>(
//    builder.Configuration.GetConnectionString("DefaultConnection"), null,
//    optionsBuilder => optionsBuilder.EnableSensitiveDataLogging(builder.Environment.IsDevelopment()));
// Add Database service 

/////implement infrastructure DependencyInjection container
builder.Services.AddInfrastructure(builder.Configuration);

// Add services to the container.
builder.Services.AddDbContext<Context>() ;
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddScoped<IMemberRepository, MemberRepository>();
//builder.Services.AddScoped<IMemberService, MemberService>();
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