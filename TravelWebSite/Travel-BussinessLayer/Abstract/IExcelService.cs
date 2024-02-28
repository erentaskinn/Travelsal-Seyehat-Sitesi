using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_BussinessLayer.Abstract
{
    public interface IExcelService
    {
        byte[] ExelList<T>(List<T> t)where T :class;
    }
}
