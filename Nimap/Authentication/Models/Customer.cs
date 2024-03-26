using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }

        public string Address { get; set; }

        public DateTime BirthDate { get; set; }
        public bool IsSubscribedToNowletter { get; set; }

        public string Password { get; set; }

    }
}