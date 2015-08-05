using System;
using System.ComponentModel.DataAnnotations;

namespace PandyIT.HMS.Data.Model.Entities
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public int UserTypeId { get; set; }

        public UserType UserType { get; set; }
    }
}
