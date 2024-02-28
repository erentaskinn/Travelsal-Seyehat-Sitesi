using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Travel_BussinessLayer.Concrete;
using Travel_DataAccessLayer.EntityFramework;
using Travels_EntityLayer.Concrete;

namespace TravelWebSite.ViewComponents.MemberDashboard
{
    public class _GuidList:ViewComponent
    {
        GuidManager guidManager =new GuidManager(new EfGuideDal());
       public IViewComponentResult Invoke(int Id)
        {
            var values = guidManager.TGetList();
            return View(values);
        }
    }
}
