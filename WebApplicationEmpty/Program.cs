//PHASE 1 - configuring of webapp
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();





//PHASE 2 - Middleware pipelining (Configure the HTTP request pipeline).

var app = builder.Build();

app.UseRouting();
/*
app.MapGet("/", () => "Hello World!");
*/

// Exercise Mapping
//app.Map("/welcome", () => "Hello and welcome");
//app.MapGet("/blogPost/{date}", (DateTime date) => DbService.getBlog(date));

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=birthday}/{action=index}"); // = default values.






//PHASE 3  - Server started
app.Run();
