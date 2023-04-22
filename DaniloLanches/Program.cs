using DaniloLanches.Context;
using DaniloLanches.Interfaces;
using DaniloLanches.Models;
using DaniloLanches.Repositories;
using Microsoft.EntityFrameworkCore;

// Ponto de entrada da aplicação
var builder = WebApplication.CreateBuilder(args);

// Adiciona o serviço do banco de dados
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Adiciona o serviço de repositório
builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddScoped<ILancheRepository, LancheRepository>();
// Adiciona o serviço de carrinho de compras
builder.Services.AddScoped(sp => CarrinhoCompra.GetCarrinho(sp));

// Adiciona o serviço de acesso ao contexto HTTP
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

// Adiciona os serviços necessários para o suporte de controladores e views no aplicativo ASP.NET Core
builder.Services.AddControllersWithViews();

builder.Services.AddMemoryCache();
builder.Services.AddSession();

// Cria o objeto da aplicação
var app = builder.Build();

// Configura o ambiente de desenvolvimento
if (!app.Environment.IsDevelopment())
{
    // O aplicativo usa o middleware de exceção para capturar e manipular exceções não tratadas.
    app.UseExceptionHandler("/Home/Error");

    // O aplicativo usa o HSTS para proteger contra ataques de protocolo seguro (HTTPS).
    app.UseHsts();
}

// Habilita redirecionamento para HTTPS
app.UseHttpsRedirection();

// Habilita o uso de arquivos estáticos
app.UseStaticFiles();

// Habilita o uso de rotas
app.UseRouting();

// Habilita o uso de sessão
app.UseSession();

// Habilita o uso de autorização
app.UseAuthorization();

// Configura as rotas
app.MapControllerRoute(
    name: "categoriaFiltro",
    pattern: "Lanches/{action}/{categoria?}",
    defaults: new { Controller = "Lanches", action = "List" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Inicia a aplicação
app.Run();
