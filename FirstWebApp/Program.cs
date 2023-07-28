
// Add services to the container.
#if true
WebApplication
#endif.CreateBuilder(args).Services.AddRazorPages();

var app = WebApplication.CreateBuilder(args).Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
