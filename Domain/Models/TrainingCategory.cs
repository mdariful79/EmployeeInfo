using RapidFireLib.Lib.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class TrainingCategory : IModel
    {
        [Key]
        public int CategoryId{ get; set; }
        public string CategoryName { get; set; }
        public bool TrainingStatus { get; set; }
    }
}
