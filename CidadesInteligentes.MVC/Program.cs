using AutoMapper;
using CidadesInteligentes.Aplicacao.Aplicacoes;
using CidadesInteligentes.Aplicacao.Interfaces;
using CidadesInteligentes.Dominio.Interfaces;
using CidadesInteligentes.Infra.Dados.Repositorio;
using CidadesInteligentes.MVC.Automapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IEstacoesRecargaApp, EstacoesRecargaApp>();
builder.Services.AddSingleton<IEstacaoRecarga, EstacaoRecargaRepositorio>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
