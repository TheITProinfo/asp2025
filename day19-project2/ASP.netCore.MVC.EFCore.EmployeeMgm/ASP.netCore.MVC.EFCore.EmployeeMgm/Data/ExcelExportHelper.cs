using ASP.netCore.MVC.EFCore.EmployeeMgm.ViewModels;
using ClosedXML.Excel;

namespace ASP.netCore.MVC.EFCore.EmployeeMgm.Data;

public static class ExcelExportHelper
{
    public static byte[] ExportEmployeesToExcel(List<EmployeeViewModel> employees)
    {
        using var workbook = new XLWorkbook();
        var worksheet = workbook.Worksheets.Add("Employees");

        // Headers
        worksheet.Cell(1, 1).Value = "Employee ID";
        worksheet.Cell(1, 2).Value = "First Name";
        worksheet.Cell(1, 3).Value = "Last Name";
        worksheet.Cell(1, 4).Value = "Email";
        worksheet.Cell(1, 5).Value = "Phone Number";
        worksheet.Cell(1, 6).Value = "Address";
        worksheet.Cell(1, 7).Value = "Gender";
        worksheet.Cell(1, 8).Value = "Date of Birth";
        worksheet.Cell(1, 9).Value = "Is Active";
        worksheet.Cell(1, 10).Value = "Department";
        worksheet.Cell(1, 11).Value = "Photo File Name";

        // Data rows
        int row = 2;
        foreach (var emp in employees)
        {
            worksheet.Cell(row, 1).Value = emp.EmployeeId;
            worksheet.Cell(row, 2).Value = emp.FirstName;
            worksheet.Cell(row, 3).Value = emp.LastName;
            worksheet.Cell(row, 4).Value = emp.Email;
            worksheet.Cell(row, 5).Value = emp.PhoneNumber;
            worksheet.Cell(row, 6).Value = emp.Address;
            worksheet.Cell(row, 7).Value = emp.Gender;
            worksheet.Cell(row, 8).Value = emp.DateOfBirth.ToShortDateString();
            worksheet.Cell(row, 9).Value = emp.IsActive ? "Yes" : "No";
            worksheet.Cell(row, 10).Value = emp.DepartmentName ?? "";
            worksheet.Cell(row, 11).Value = emp.PhotoFileName ?? "";
            row++;
        }

        using var stream = new MemoryStream();
        workbook.SaveAs(stream);
        return stream.ToArray();
    }
}