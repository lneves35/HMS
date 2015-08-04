using System;
using System.Data.Entity;
using PandyIT.HMS.Data.Model;
using PandyIT.HMS.Data.Model.Entities;

namespace PandyIT.HMS.UI.MVCFrontEnd.DatabaseInitializers
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

            var user1 = new User()
            {
                FirstName = "Luis",
                LastName = "Neves",
                UserType = userAdmin,
                BirthDate = new DateTime(1979, 7, 9)
            };
            context.Users.Add(user1);

        }
    }
}