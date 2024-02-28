using Microsoft.AspNetCore.Mvc;
using Travel_BussinessLayer.Concrete;
using Travel_DataAccessLayer.EntityFramework;

namespace TravelWebSite.ViewComponents.Default
{
    public class _PopularDestinations:ViewComponent
    {
        DestinationManager _DestinationManager=new DestinationManager(new EfDestinationDal());
        public IViewComponentResult Invoke() 
        {
            var values = _DestinationManager.TGetList();
            return View(values);
        }
    }
}
