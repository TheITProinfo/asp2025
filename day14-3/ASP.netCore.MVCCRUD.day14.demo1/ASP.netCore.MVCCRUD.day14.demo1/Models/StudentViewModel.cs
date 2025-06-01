namespace ASP.netCore.MVCCRUD.day14.demo1.Models;

public class StudentViewModel
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; }
}
