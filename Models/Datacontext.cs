using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_Crud.Models
{
    public class Datacontext:DbContext
    {
        public DbSet<Data>datas {  get; set; }
    }
}