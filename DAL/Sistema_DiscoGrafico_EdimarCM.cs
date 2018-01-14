using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using Entidades;

namespace DAL
{
    public class Sistema_DiscoGrafico_EdimarCM: DbContext
    {
        public Sistema_DiscoGrafico_EdimarCM() : base("name = ConStr")
        {
                
        }
        public virtual DbSet<Usuarios>usuario { get; set; }
    }
}
