using RapidFireLib.Lib.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Designation : IModel
    {
        [Key]
        public int DesignationId { get; set; }
        public int? DepartmentId { get; set; }
        public string DesignationName { get; set; }
        
    }
}
