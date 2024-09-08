
using Agenda_de_Contatos.Model;

namespace Agenda_de_Contatos.Modelo;
public class Contato
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Fone {  get; set; }
    public string Email { get; set; }

    //Associação
    public Endereco Endereco { get; set; }
}

