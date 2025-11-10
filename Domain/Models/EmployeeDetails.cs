using RapidFireLib.Lib.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class EmployeeDetails : IModel
    {
        [Key]
        public int EmployeeDetailsId { get; set; }
        public int EmployeeId { get; set; }
       

    }
}
