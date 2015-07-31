using System;

namespace PandyIT.HMS.Data.Entities.Entities
{
    public class User
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public int UserTypeId { get; set; }

        public UserType UserType { get; set; }
    }
}
