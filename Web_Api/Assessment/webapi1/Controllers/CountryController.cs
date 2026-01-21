using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapiEx.Models;

namespace webapiEx.Controllers
{
    [RoutePrefix("api/Country")]
    public class CountryController : ApiController
    {
        static List<Country> countries = new List<Country>
        {
            new Country { ID = 1, CountryName = "India", Capital = "Delhi" },
            new Country { ID = 2, CountryName = "Italy", Capital = "Rome" }
        };

        //GetCountryAll
        [HttpGet]
        [Route("All")]
        public IEnumerable<Country> GetAllCountries()
        {
            return countries;
        }

        //GetCountryById
        [HttpGet]
        [Route("ById/{pId}")]
        public IHttpActionResult GetCountryById(int pId)
        {
            var country = countries.FirstOrDefault(c => c.ID == pId);
            if (country == null)
                return NotFound();

            return Ok(country);
        }

        // PostCountryAll
        [HttpPost]
        [Route("AllPost")]
        public IHttpActionResult PostCountry([FromBody] Country country)
        {
            if (country == null)
                return BadRequest("Invalid data");

            countries.Add(country);
            return Ok(countries);
        }

        [HttpPost]
        [Route("countrypost")]
        public IHttpActionResult PostCountryByParams([FromUri] int Id, string name, string capital)
        {
            Country country = new Country
            {
                ID = Id,
                CountryName = name,
                Capital = capital
            };

            countries.Add(country);
            return Ok(countries);
        }

        [HttpPut]
        [Route("update/{pid}")]
        public IHttpActionResult PutCountry(int pid, [FromBody] Country updatedCountry)
        {
            var existingCountry = countries.FirstOrDefault(c => c.ID == pid);
            if (existingCountry == null)
                return NotFound();

            existingCountry.CountryName = updatedCountry.CountryName;
            existingCountry.Capital = updatedCountry.Capital;

            return Ok(existingCountry);
        }

       
        [HttpDelete]
        [Route("delete/{pid}")]
        public IHttpActionResult DeleteCountry(int pid)
        {
            var country = countries.FirstOrDefault(c => c.ID == pid);
            if (country == null)
                return NotFound();

            countries.Remove(country);
            return Ok(countries);
        }
    }
}

