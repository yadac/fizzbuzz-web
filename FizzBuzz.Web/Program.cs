using FizzBuzz.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// データベース接続文字列の設定
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddDefaultIdentity<IdentityUser>(Options =>
    Options.SignIn.RequireConfirmedAccount = false)
.AddEntityFrameworkStores<ApplicationDbContext>();

// コントローラーとRazorページのサービスを追加
builder.Services.AddControllers();
builder.Services.AddRazorPages();

var app = builder.Build();

// アプリケーションの環境に応じたミドルウェアの設定
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

// HTTPSリダイレクトとデフォルトファイルの設定
app.UseHttpsRedirection();
app.UseDefaultFiles();

// 静的ファイルの配信
app.UseStaticFiles();

// SPAのルーティングを設定
app.UseRouting();

// 認証と承認のミドルウェアを追加
app.UseAuthentication();
app.UseAuthorization();

// APIコントローラーとRazorページのマッピング
app.MapControllers();
app.MapRazorPages();
app.MapFallbackToFile("/spa/{*path:nonfile}", "spa/index.html");

app.Run();
