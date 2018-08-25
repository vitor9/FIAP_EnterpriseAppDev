using Fiap06.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap06.Web.MVC.Persistencia
{
    public class BotecoContex : DbContext
    {
        public DbSet<Bebida> Bebidas { get; set; }
        public DbSet<Petisco> Petiscos { get; set; }
    }
}