var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

// Get the port from environment variable or default to 5000
var port = Environment.GetEnvironmentVariable("PORT") ?? "5000";

// Tell the app to listen on that port on all network interfaces
app.Urls.Add($"http://*:{port}");

app.Run();
