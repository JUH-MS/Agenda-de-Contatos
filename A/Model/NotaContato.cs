using Agenda_de_Contatos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_de_Contatos.Model;
public class NotaContato
{
    public string Id { get; set; }

    public string Texto { get; set; }

    //Outra Associação
    public Contato Contato { get; set; }

}
