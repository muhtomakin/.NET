using MiddlewarePractices.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

app.UseHello();

app.Use(async (context, next) => 
{
    Console.WriteLine("Middleware executing!");
    await next.Invoke();
});

app.Map("/example", internalApp =>
    internalApp.Run(async context =>
    {
        Console.WriteLine("/example middleware trigered!");
        await context.Response.WriteAsync("/example middleware triggered");
    }));

app.MapWhen(x => x.Request.Method == "GET", internalApp => {
    internalApp.Run(async context => {
        Console.WriteLine("MapWhen middleware trigered!");
        await context.Response.WriteAsync("MapWhen middleware triggered");
    });
});

app.Run();

