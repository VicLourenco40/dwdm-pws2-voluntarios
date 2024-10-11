using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using dwdm_pws2_voluntarios.Models;

namespace dwdm_pws2_voluntarios.Data
{
    public class dwdm_pws2_voluntariosContext : DbContext
    {
        public dwdm_pws2_voluntariosContext (DbContextOptions<dwdm_pws2_voluntariosContext> options)
            : base(options)
        {
        }

        public DbSet<dwdm_pws2_voluntarios.Models.Voluntario> Voluntario { get; set; } = default!;
    }
}
