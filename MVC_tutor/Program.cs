using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//Khi các bạn muốn add service thì các bạn phải add ở đây
//dưới var builder và trên var app
///ví dụ: add chuỗi connectitring, add DI

var app = builder.Build();

// Configure the HTTP request pipeline.
//kiểm tra xem có phải môi trường dev hay k
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // sử dụng tài nguyên tĩnh -> wwwroot

app.UseRouting();   //cấu hình địnhh tuyến 

app.UseAuthorization();   
//cấu hình cách thức ddeer truy cập action trong controller
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//httpslocalhost1234/ conntrolerName/ actionNameeeeee/ {idddddddddddddddđ? }

app.Run();
