using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagmentSystem.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public int CityName { get; set; }
    }
}
