using Agenda_de_Contatos.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AgendaDeContatos.DataBase;

public class AgendaDBContextFactory : IDesignTimeDbContextFactory<AgendaDBContext>
{
    public AgendaDBContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AgendaDBContext>();
        optionsBuilder.UseSqlite("Data Source=DataBase/Agenda.db");

        return new AgendaDBContext(optionsBuilder.Options);
    }
}