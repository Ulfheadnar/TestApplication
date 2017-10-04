using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using JobTestProject.Models;

namespace JobTestProject.Data
{   //! Class of the initializator;
    public class InitializatorDb:DropCreateDatabaseAlways<AcuaintanceContext>
    {
        //! Overrided method which inializes db with two obj. Is turned off in Global.asax;
        protected override void Seed(AcuaintanceContext context)
        {
            context.MyAcuaintances.Add(new MyAcuaintance
            {
                Id = 0,
                Name = "Apollo",
                Surname = "Apollonowich",
                Email = "apollonowich@gmail.com",
                Phone = "791578434",
                Description = "Magna clita accusam sea enim dolor at" +
                " nonumy qui consequat nulla ad sed est et takimata" +
                " illum amet blandit erat"
            });
            context.MyAcuaintances.Add(new MyAcuaintance
            {
                Id = 1,
                Name = "Someone",
                Surname = "Someone",
                Email = "qwe@gmail.com",
                Phone = "12318434",
                Description = "Magna clita accusam sea enim dolor at" +
                " nonumy qui consequat nulla ad sed est et takimata" +
                " illum amet blandit erat"
            });


            base.Seed(context);
        }
    }
}