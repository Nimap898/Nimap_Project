using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication5.Dtos
{
    public class CustomerDto
    {
        
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public DateTime BirthDate { get; set; }
        public bool IsSubscribedToNowletter { get; set; }
    }
}