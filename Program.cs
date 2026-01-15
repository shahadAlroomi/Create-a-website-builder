var builder = WebApplication.CreateBuilder(args); // create a website builder
builder.WebHost.UseUrls("http://0.0.0.0:5000");

var app = builder.Build();

List<Registration> registrations = [];

app.MapGet("/api/time", () => DateTime.Now.ToLongTimeString());

app.MapGet("/api/date", () => DateOnly.FromDateTime(DateTime.Now).ToLongDateString());
app.MapGet("/api/registrations", () => registrations);
app.MapPost("/api/registrations", (Registration rd) => registrations.Add(rd));
app.UseDefaultFiles();
app.UseStaticFiles();



app.Run(); // open http://127.0.0.1:5000/index.html

record Registration(string Name , string Email);

//GET / wwwroot/image.png
//GET /time
