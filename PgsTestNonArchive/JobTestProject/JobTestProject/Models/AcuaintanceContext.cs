using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace JobTestProject.Models
{
    //! Class which is Db context and includes DbSet<MyAcuaintance>;
    public class AcuaintanceContext:DbContext
    {
        public DbSet<MyAcuaintance> MyAcuaintances { get; set; }

        //! Constructor which is contain the name of ConnectionString "AcuaintanceContext";
        public AcuaintanceContext() : base("AcuaintanceContext")
        {

        }

       
    }
}