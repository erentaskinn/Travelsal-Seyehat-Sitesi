using Microsoft.AspNetCore.Mvc;
using Travel_BussinessLayer.Concrete;
using Travel_DataAccessLayer.Abstract;
using Travel_DataAccessLayer.EntityFramework;

namespace TravelWebSite.ViewComponents.Default
{
    public class _Testimonials:ViewComponent
    {
        TestimonialManager TestimonialManager = new TestimonialManager(new EfTestimonial());
        public IViewComponentResult Invoke()
        {
            var values = TestimonialManager.TGetList();
            return View(values);
        }
    }
}
