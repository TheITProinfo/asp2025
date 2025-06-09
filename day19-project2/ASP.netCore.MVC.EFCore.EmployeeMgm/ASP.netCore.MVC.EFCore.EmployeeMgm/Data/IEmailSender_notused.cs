namespace ASP.netCore.MVC.EFCore.EmployeeMgm.Data;

public interface IEmailSender_notused
{
    Task SendEmailAsync(string email, string subject, string message);
}
