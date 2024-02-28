using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using Travel_BussinessLayer.Abstract;
using Travel_DataAccessLayer.Concerate;
using TravelWebSite.Models;

namespace TravelWebSite.Controllers
{
    public class ExelController : Controller
    {
        private readonly IExcelService _excelService;
        public ExelController(IExcelService excelService)
        {
            _excelService = excelService;
        }
        public IActionResult Index()
        {
            
           return View();
        }
        public List<DestinationModel> DestinationList()
        {
            List<DestinationModel> destinationModels = new List<DestinationModel>();
            using (var c =new Context())
            {
                destinationModels = c.Destinations.Select(x => new DestinationModel
                {
                    City = x.City,
                    DayNight=x.DateNight,
                    Price=x.Price,
                    Capacity=x.Capacity

                }).ToList();
            }
            return destinationModels;
        } 
        public IActionResult StaticExcelReport()
        {
            return File(_excelService.ExelList(DestinationList()), "aplication/vnd.openxmlformats-officedocument.spread.sheet","YeniExcel.xlsx");
            //aplication / vnd.openxmlformats - officedocument.spread.sheet
        }
        public IActionResult DestinationExelReport()
        {
            using (var workbook = new XLWorkbook())
            {
                var workSheet = workbook.Worksheets.Add("Tur Listesi");
                workSheet.Cell(1, 1).Value = "Şehir";
                workSheet.Cell(1, 2).Value = "Konaklama Süresi";
                workSheet.Cell(1, 3).Value = "Fiyat";
                workSheet.Cell(1, 4).Value = "Kapasite";

                int rowCount = 2;

                foreach(var item in DestinationList())
                {
                    workSheet.Cell(rowCount, 1).Value = item.City;
                    workSheet.Cell(rowCount, 2).Value = item.DayNight;
                    workSheet.Cell(rowCount, 3).Value = item.Price;
                    workSheet.Cell(rowCount, 4).Value = item.Capacity;
                    rowCount++;

                }
                using (var stream=new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content=stream.ToArray();
                    return File(content, "aplication/vnd.openxmlformats-officedocument.spread.sheet", "Yeni Liste.xlsx");
                }
            }
        }
    }
}
