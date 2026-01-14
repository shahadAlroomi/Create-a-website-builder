var builder = WebApplication.CreateBuilder(args); // create a website builder
builder.WebHost.UseUrls("http://0.0.0.0:5000");

var app = builder.Build();
app.UseDefaultFiles();
app.UseStaticFiles();



app.Run(); // open http://127.0.0.1:5000/index.html