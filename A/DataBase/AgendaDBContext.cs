using Agenda_de_Contatos.Model;
using Agenda_de_Contatos.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Agenda_de_Contatos.DataBase;
public class AgendaDBContext(DbContextOptions<AgendaDBContext> options) : DbContext(options)
{

    public DbSet<Contato> Contatos { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<GrupodeContato> Grupos { get; set; }
    public DbSet<NotaContato> NotasContato { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Contato>().HasKey(c => c.Id);

        // Configuração para Endereço (1:1 com Contato)
        builder.Entity<Contato>()
                   .HasOne(c => c.Endereco)
                   .WithOne(e => e.Contato)
                   .HasForeignKey<Endereco>(e => e.ContatoId)  
                   .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<GrupodeContato>().HasKey(g => g.Id);

        builder.Entity<NotaContato>().HasKey(n => n.Id);

        // Relacionamento 1:N entre Contato e NotaContato
        builder.Entity<NotaContato>()
               .HasOne(n => n.Contato)
               .WithMany()
               .OnDelete(DeleteBehavior.Cascade);

        base.OnModelCreating(builder);

    }
}
