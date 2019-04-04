using System;
using System.Collections.Generic;

namespace HourlyChecker.Models
{
    public partial class DataTable
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Qualification { get; set; }
        public string Date { get; set; }
        public string Hour { get; set; }
        public string Minutes { get; set; }
    }
}
