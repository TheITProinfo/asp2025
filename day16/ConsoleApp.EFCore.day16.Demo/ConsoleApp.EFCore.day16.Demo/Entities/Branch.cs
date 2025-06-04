using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.EFCore.day16.Demo.Entities;
public class Branch
{
    public int Id { get; set; }
    public string? BranchName { get; set; } = null!;
    public string? Description { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
    // collection navigation property - one branch can have many students
    public ICollection<Student> Students { get; set; } = null!;
}
