using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastrodeClientes.Models;
namespace CadastrodeClientes.Data
{
    public class AppDBContenxt : DbContext
    { 
        public AppDBContenxt(DbContextOptions<AppDBContenxt> options) : base(options){}
        public DbSet<Cliente> clientes;
        public DbSet<CadastrodeClientes.Models.Cliente> Cliente { get; set; }
    }
}
