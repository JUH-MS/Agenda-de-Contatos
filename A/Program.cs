using Agenda_de_Contatos.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

public class Program()
{
    static async Task Main(string[] args)
    {
        // Configuração dos serviços
        var serviceProvider = new ServiceCollection()
            .AddDbContext<AgendaDBContext>(options =>
                options.UseSqlite("Data Source=DataBase/Agenda.db"))
            .BuildServiceProvider();

        // Armazenar o serviceProviser em uma classe estática
        ServiceProviderContainer.ServiceProvider = serviceProvider;

    }

}