using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using PandyIT.HMS.Data.Model;
using PandyIT.HMS.Data.Model.Entities;

namespace PandyIT.HMS.UI.MVCFrontEnd.App_Start.DatabaseInitializers
{
    public class DropCreateHmsDbAlways : DropCreateDatabaseAlways<HmsContext>
    {
        protected override void Seed(HmsContext context)
        {
            base.Seed(context);

            var userAdmin = new UserType() { Name = "Administrator" };
            var userTypeEmployee = new UserType() { Name = "Employee" };
            var userTypeCustomer = new UserType() { Name = "Customer" };

            context.UserTypes.Add(userAdmin);
            context.UserTypes.Add(userTypeEmployee);
            context.UserTypes.Add(userTypeCustomer);
        }
    }
}