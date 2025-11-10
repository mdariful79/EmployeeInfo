using Microsoft.AspNetCore.Components.Forms;
using RapidFireLib.Lib.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models;

public class Employees : IModel
{
    [Key]
    public int EmployeesId { get; set; }
    public int? DepartmentId { get; set; }
    public int? DesignationId { get; set; }
    public int? CategoryId { get; set; }
    public int? TrainingId { get; set; }
    [Required]
    public string EmployeeName { get; set; }
    public decimal EmployeeAge { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public DateTime? JobStart { get; set; }
    public DateTime? JobEnd { get; set; }
    public int? Gender { get; set; }
    public string JobDescription { get; set; }
    public bool IsActive { get; set; }

    public string ProfilePicPath { get; set; }
    [NotMapped]
    public List<IBrowserFile> ProfilePic { get; set; }

    public List<Training> Training { get; set; } = new();

}
public class EmployeesVM : IModel
{
    [Key]
    public int EmployeesId { get; set; }

    public string EmployeeName { get; set; }
    public string EmployeeAge { get; set; }
    public string DateOfBirth { get; set; }
    public string JobStart { get; set; }
    public string JobEnd { get; set; }
    public string Gender { get; set; }
    public string JobDescription { get; set; }
    public string IsActive { get; set; }

    public string DepartmentName { get; set; }
    public string DesignationName { get; set; }
    public string CategoryName { get; set; }
    public string TrainingName { get; set; }
    public string ProfilePicPath { get; set; }
    public int TotalRecord { get; set; }
}
