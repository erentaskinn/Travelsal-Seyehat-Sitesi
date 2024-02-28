using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using TravelWebSite.Areas.Admin.Models;

namespace TravelWebSite.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class BookingHotelSearchController : Controller
    {
        
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/hotels/search?order_by=popularity&checkout_date=2024-05-20&filter_by_currency=EUR&locale=en-gb&units=metric&dest_id=-1746443&dest_type=city&adults_number=2&room_number=1&checkin_date=2024-05-19&include_adjacency=true&page_number=0&children_number=2&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&children_ages=5%2C0"),
                Headers =
                {
        { "X-RapidAPI-Key", "89addf0a8fmsh01b917441c763ffp14457ejsn00c930bcb449" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var bodReplaace = body.Replace(".", "");
                var values = JsonConvert.DeserializeObject<BookingHotelSearchVm>(bodReplaace);
                return View(values.result);
            }

        }
        [HttpGet]
        public IActionResult GetCityDestinationId()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetCityDestinationId(string city)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={city}&locale=en-gb"),
                Headers =
                {
        { "X-RapidAPI-Key", "89addf0a8fmsh01b917441c763ffp14457ejsn00c930bcb449" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                return View();
            }
        }
    }
}
