using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Reflection.Metadata.Ecma335;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/pedidos", async (Pedido pedidoNovo, AppDbContext db) => {
    db.pedidos.Add(pedidoNovo);
    await db.SaveChangesAsync();
    return Results.Created($"Pedido: {pedidoNovo.nome}", pedidoNovo);
});

app.MapGet("/pedidos", async (AppDbContext db) => {
    // ToListAsync(); => para listas o banco
    return db.pedidos.ToListAsync();
});

app.MapGet("/pedidos/{id}", async (int id, AppDbContext db) => {
    var pedidoAchado = await db.pedidos.FindAsync(id);
    return pedidoAchado is not null ? Results.Ok(pedidoAchado) : Results.NotFound();
});

app.MapGet("/pedidos/nome/{nome}", async (String nome, AppDbContext db) => {

    var pedidos = await db.pedidos.Where(p => p.nome == nome).ToListAsync();

    return pedidos is not null ? Results.Ok(pedidos) : Results.NotFound();
});

app.MapPut("/pedidos/{id}", async (int id, Pedido pedidoNovo, AppDbContext db) => {
    var pedidoAchado = await db.pedidos.FindAsync(id);

    if(pedidoAchado is not null)
    {
        pedidoAchado.nome = pedidoNovo.nome;
        pedidoAchado.produto = pedidoNovo.produto;
        pedidoAchado.quantidade = pedidoNovo.quantidade;
        pedidoAchado.preco = pedidoNovo.preco;
    }

    // NÃO PODE ESQUECER DE SALVAR
    await db.SaveChangesAsync();

    return pedidoAchado is not null ? Results.Ok(pedidoAchado) : Results.NotFound();
});

app.MapDelete("/pedidos/{id}", async (int id, AppDbContext db) => {
    var pedidoAchado = await db.pedidos.FindAsync(id);

    if(pedidoAchado is not null)
    {
        db.pedidos.Remove(pedidoAchado);
    }

    // NÃO PODE ESQUECER DE SALVAR
    await db.SaveChangesAsync();

    return pedidoAchado is not null ? Results.Ok(pedidoAchado) : Results.NotFound();
});

app.Run();

public class AppDbContext : DbContext
{
    public DbSet<Pedido> pedidos => Set<Pedido>();

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite("Data Source=pedidos.db");
    }
}

public class Pedido
{
    public int id { get; set; }
    public string ?nome { get; set; }
    public string ?produto { get; set; }
    public int quantidade { get; set; }
    public double preco { get; set; }
}