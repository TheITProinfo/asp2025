using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcore.day15.demo1.Entities;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Email { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? PhoneNumber { get; set; }
    public DateTime EnrollmentDate { get; set; }

    // Navigation Property -- one student can be enrolled in one branch
    public virtual Branch Branch { get; set; } = null!;


}
