using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.IO.Image;
using System.Collections.Generic;
using System.IO;
using ASP.netCore.MVC.EFCore.EmployeeMgm.ViewModels;
using iText.IO.Image;

public static class PdfExportHelper
{
    public static byte[] ExportEmployeesToPdf(List<EmployeeViewModel> employees, string imagesFolderPath)
    {
        using var ms = new MemoryStream();
        using var writer = new PdfWriter(ms);
        using var pdf = new PdfDocument(writer);
        var document = new Document(pdf);

        // Define table with 5 columns (adjust as needed)
        var table = new Table(7);

        // Add headers
        table.AddHeaderCell("Employee ID");
        table.AddHeaderCell("Name");
        table.AddHeaderCell("Email");
        table.AddHeaderCell("Department");
       
        table.AddHeaderCell("Gender");         // Added Gender header
        table.AddHeaderCell("DateOfBirth");         // Added Gender header
        table.AddHeaderCell("Photo");

        foreach (var emp in employees)
        {
            table.AddCell(emp.EmployeeId.ToString());
            table.AddCell($"{emp.FirstName} {emp.LastName}");
            table.AddCell(emp.Email);
            table.AddCell(emp.DepartmentName ?? "");
            table.AddCell(emp.Gender ?? "");                  // Add Gender data
            table.AddCell(emp.DateOfBirth.ToString("yyyy-MM-dd"));


            // Add photo if exists
            if (!string.IsNullOrEmpty(emp.PhotoFileName))
            {
                var photoPath = Path.Combine(imagesFolderPath, emp.PhotoFileName);
                if (File.Exists(photoPath))
                {
                    ImageData imageData = ImageDataFactory.Create(photoPath);
                    Image pdfImage = new Image(imageData);
                    pdfImage.SetMaxHeight(50);
                    pdfImage.SetAutoScale(true);

                    var cell = new Cell();
                    cell.Add(pdfImage);
                    table.AddCell(cell);
                }
                else
                {
                    table.AddCell("No Image");
                }
            }
            else
            {
                table.AddCell("No Image");
            }
        }

        document.Add(table);
        document.Close();

        return ms.ToArray();
    }
}
