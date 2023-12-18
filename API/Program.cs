using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();


//Add DataCntext and Config With fremwork >>
builder.Services.AddDbContext<DataContext>(opt => 
{opt.UseSqlite(builder.Configuration.GetConnectionString("DefultConnection"));} );


// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//app.Run();

