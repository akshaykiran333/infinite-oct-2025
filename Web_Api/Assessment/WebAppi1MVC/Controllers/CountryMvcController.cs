using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebAppi1MVC.Models;


namespace WebAppi1MVC.Controllers
{
    public class CountryMvcController : Controller
    {
        //// GET: CountryMvc
        //public async Task<ActionResult> Index()
        //{
        //    using (HttpClient client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri("https://localhost:44395/");

        //        var response = await client.GetAsync("api/country/getall");

        //        if (response.IsSuccessStatusCode)
        //        {
        //            var data = await response.Content.ReadAsAsync<IEnumerable<Country>>();
        //            return View(data);
        //        }
        //    }

        //    return View(new List<Country>());
        //}
        public async Task<ActionResult> Index()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44395/");

                // Correct URL
                var response = await client.GetAsync("api/Country/All");

                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<IEnumerable<Country>>();
                    return View(data);
                }
                else
                {
                    // For debugging
                    ViewBag.Error = response.StatusCode.ToString();
                    return View(new List<Country>());
                }
            }
        }
    }
 }
