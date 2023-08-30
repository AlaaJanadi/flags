using Flags.Models;
using Flags.Services;
using Microsoft.AspNetCore.Mvc;

namespace Flags.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountryController : Controller
    {
        private readonly ICountryService countryService;

        public CountryController(ICountryService countryService)
        {
            this.countryService = countryService;
        }

        [HttpGet]
        public Task<List<Country>> GetAll()
        {
            return this.countryService.GetAll();
        }

        [HttpGet("{id}")]
        public Task<Country> Get(int id)
        {
            return this.countryService.GetByID(id);
        }

        [HttpGet("str/{id}")]
        public Task<Country> GetByStringId(string id)
        {
            return this.countryService.GetById(id);
        }

        [HttpGet("tld/{tld}")]
        public Task<Country> GetByTld(string tld)
        {
            return this.countryService.GetByTld(tld);
        }

        [HttpGet("con/{con}")]
        public Task<List<Country>> GetAllByContinent(string con)
        {
            return this.countryService.GetByContinent(con);
        }

        [HttpGet("get4/{id1}/{id2}/{id3}/{id4}")]
        public Task<List<Country>> Get4(int id1, int id2, int id3, int id4)
        {
            return this.countryService.Get4(id1, id2, id3, id4);
        }
    }
}
