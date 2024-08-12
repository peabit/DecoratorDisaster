using DecoratorDisaster;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerGen();

builder.Services.AddControllers();

builder.Services.AddScoped<IServiceOne, ServiceOne>();
builder.Services.Decorate<IServiceOne, Decorator>();

builder.Services.AddScoped<IServiceTwo, ServiceTwo>();
builder.Services.Decorate<IServiceTwo, Decorator>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();