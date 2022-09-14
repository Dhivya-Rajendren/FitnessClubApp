var builder = WebApplication.CreateBuilder(args);


builder.Services.AddRazorPages();// registering the services needed for building Razor page.

WebApplication webApp = builder.Build();



if (webApp.Environment.IsDevelopment())
{
    webApp.UseDeveloperExceptionPage();// Middleware for showing developer specific exception page .
}
webApp.UseHttpsRedirection();
webApp.UseStaticFiles();

webApp.UseRouting();// match the request to an endpoint.http://localhost/trainer.cshtml

webApp.UseAuthorization();

webApp.MapRazorPages(); // index.cshtml, aboutus.cshtml, trainer.cshtml, trainer.html, a.css. build.js

webApp.Run();