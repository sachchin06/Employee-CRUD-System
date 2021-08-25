using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagmentSystem.Models
{
   
    public class Employee
    {

        [Key]
        [Column("EmpId")]
        public int EmployeeId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }

        [Column("Dob", TypeName = "DateTime2")]
        public DateTime DateOfBirth { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string telNumber { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        public string Email { get; set; }

        [Column(TypeName = "nvarchar(6)")]
        public bool MaritalStatus { get; set; }

        
        public int CityId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Remark { get; set; }
    }
}

