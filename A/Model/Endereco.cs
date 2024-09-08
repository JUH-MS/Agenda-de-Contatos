using Agenda_de_Contatos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_de_Contatos.Model;
public class Endereco
{
    public int Id { get; set; }
    public string Cep { get; set; } 
    public string Logradouro { get; set; }
    public string Bairro { get; set; }

    //Chave estrangeira
    public int ContatoId { get; set; }

    // Propriedade de navegação para o Contato
    public Contato Contato { get; set; }
}
