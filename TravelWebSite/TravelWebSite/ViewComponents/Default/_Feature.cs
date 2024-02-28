using Microsoft.AspNetCore.Mvc;
using Travel_BussinessLayer.Concrete;
using Travel_DataAccessLayer.Concerate;
using Travel_DataAccessLayer.EntityFramework;

namespace TravelWebSite.ViewComponents.Default
{
    public class _Feature:ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            //var values=featureManager.TGetList();

            return View();
        }
    }
}
