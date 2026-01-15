var builder = WebApplication.CreateBuilder(args); // create a website builder
builder.WebHost.UseUrls("http://0.0.0.0:5000");

var app = builder.Build();

app.MapGet("/time", () => DateTime.Now.ToLongTimeString());

app.MapGet("/date", () => DateOnly.FromDateTime(DateTime.Now).ToLongDateString());
app.UseDefaultFiles();
app.UseStaticFiles();



app.Run(); // open http://127.0.0.1:5000/index.html

//GET / wwwroot/image.png
//GET /time
