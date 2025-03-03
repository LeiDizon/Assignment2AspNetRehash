var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();//Added for the HomeControllers.cs to controll the route
var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/", () => "Library Thing :)");
app.MapControllers();//Automatically maps routes


app.Run();
