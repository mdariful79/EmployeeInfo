using RapidFireLib.Lib.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Training : IModel
    {
        [Key]
        public int TrainingId { get; set; }
        public int CategoryId { get; set; }

        public string TrainingName { get; set; }
        public int EmployeesId { get; set; }
        public string Venue { get; set; }

    }
}
