using System.Runtime.Serialization;
using System.Net.Security;
using MecanicoConfiable.App.Persistencia;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAuthentication("MyCookieAuth").AddCookie("MyCookieAuth",options => {
    options.Cookie.Name = "MyCookieAuth";
    options.LoginPath = "/Account/LoginAdm";
    options.AccessDeniedPath = "/Account/AccessDenied";
});
builder.Services.AddAuthorization(options => {

   options.AddPolicy("admin",policy => policy.RequireClaim("admin"));
   options.AddPolicy("MustBelongADDepartment",policy => policy.RequireClaim("Department","AD"));
});


/* builder.Services.AddAuthentication("MyCookieAuthmec").AddCookie("MyCookieAuthmec",options => {
    options.Cookie.Name = "MyCookieAuthmec";
    options.LoginPath = "/Account/LoginAdm";
    options.AccessDeniedPath = "/Account/AccessDenied";
});
builder.Services.AddAuthorization(options => {

   options.AddPolicy("mec",policy => policy.RequireClaim("mec"));
   options.AddPolicy("MustBelongADmecepartment",policy => policy.RequireClaim("Departmentt","AM"));
}); */
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton <IRepositorioPersonal, RepositorioPersonal>();
builder.Services.AddSingleton <IRepositorioServicios, RepositorioServicios>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
