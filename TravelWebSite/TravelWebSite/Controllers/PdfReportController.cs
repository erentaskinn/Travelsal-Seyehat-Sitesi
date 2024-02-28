using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;

namespace TravelWebSite.Controllers
{
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public  IActionResult StaticPdfReport() 
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReports/" + "dosya1.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);
            
            document.Open();

            Paragraph paragraph = new Paragraph("Traversal Rezervasyon Pdf Raporu");
            document.Add(paragraph);
            document.Close();
            return File("/PdfReports/dosya2.pdf", "aplication/pdf", "dosya1.pdf");
        }
        public IActionResult StaticCustomerReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReports/" + "dosya2.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();
            PdfPTable pdfPTable = new PdfPTable(3);

            pdfPTable.AddCell("Misafir Adı");
            pdfPTable.AddCell("Misafir Soyadı");
            pdfPTable.AddCell("Misafir TC");

            pdfPTable.AddCell("Eren");
            pdfPTable.AddCell("Taşkın");
            pdfPTable.AddCell("11111111110");

            pdfPTable.AddCell("Nurşah");
            pdfPTable.AddCell("Taşkın");
            pdfPTable.AddCell("11221111110");

            pdfPTable.AddCell("Alin");
            pdfPTable.AddCell("Taşkın");
            pdfPTable.AddCell("11331111110");

            document.Add(pdfPTable);

            document.Close();
            return File("/PdfReports/dosya2.pdf", "aplication/pdf", "dosya2.pdf");
        }
    }
}
