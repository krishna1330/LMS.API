using LMS.API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// 1️⃣ Add DbContext for SQL Server
builder.Services.AddDbContext<LMSDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));



// 3️⃣ Add Controllers
builder.Services.AddControllers();

// 4️⃣ Swagger (for API testing)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 5️⃣ Configure middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// (Optional) if you add authentication later, keep this here
app.UseAuthorization();

app.MapControllers();

app.Run();
