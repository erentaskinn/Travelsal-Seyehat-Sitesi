using Microsoft.AspNetCore.Mvc;
using Travel_BussinessLayer.Concrete;
using Travel_DataAccessLayer.EntityFramework;

namespace TravelWebSite.ViewComponents.Default
{
    public class _SubAbout:ViewComponent
    {
        SubAboutManager subAboutManager = new SubAboutManager(new EfSubAboutDal());
        public IViewComponentResult Invoke()
        {
            var values = subAboutManager.TGetList();
            return View(values);
        }
    }
}
