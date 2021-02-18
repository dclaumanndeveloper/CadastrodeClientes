using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastrodeClientes.Data
{
    public class AppDBContenxt : DbContext
    { 
        public AppDBContenxt(DbContextOptions<AppDBContenxt> options) : base(options){}
    }
}
