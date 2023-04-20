using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiProject
{
    public class EmployeeInfo
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "First Name should not be empty")]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        [StringLength(10, ErrorMessage = "Contact number should not exceed 10 digits")]
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        public DateTime? DateJoined { get; set; }
        public bool Confirmed { get; set; }
    }
}
