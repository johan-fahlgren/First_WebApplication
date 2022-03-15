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

// Exercise Mapping (most specific first)
//app.Map("/welcome", () => "Hello and welcome");
//app.MapGet("/blogPost/{date}", (DateTime date) => DbService.getBlog(date));

app.MapControllerRoute(
    name: "overview",
    pattern: "birthday/overview/{month:range(1,12)?}",
    defaults: new { controller = "Birthday", action = "overview" });

app.MapControllerRoute(
    name: "birthday",
    pattern: "birthday/{date:datetime?}",
    defaults: new { controller = "Birthday", action = "Index" });



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=birthday}/{action=index}"); // = default values.




app.MapRazorPages();



//PHASE 3  - Server started
app.Run();
