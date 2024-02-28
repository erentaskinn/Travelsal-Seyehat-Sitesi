using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel_BussinessLayer.Abstract;

namespace Travel_BussinessLayer.Concrete
{
    public class ExcelManager : IExcelService
    {
        public byte[] ExelList<T>(List<T> t) where T : class
        {
           ExcelPackage excel=new ExcelPackage();
            var workSheet = excel.Workbook.Worksheets.Add("Sayfa1");

            workSheet.Cells["A1"].LoadFromCollection(t, true, OfficeOpenXml.Table.TableStyles.Light10);

            return excel.GetAsByteArray();
        }
    }
}
