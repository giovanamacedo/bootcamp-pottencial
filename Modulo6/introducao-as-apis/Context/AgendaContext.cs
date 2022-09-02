using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using introducao_as_apis.Entities;

namespace introducao_as_apis.Context
{
  public class AgendaContext : DbContext
  {
    public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
    {
      //Aqui vamos receber a conexão do banco e vamos passar para o base (DbContext)
    }

    public DbSet<Contato> Contatos { get; set; }
    //Está dentro do DbSet para ser reconhecido como tabela no banco


  }
}