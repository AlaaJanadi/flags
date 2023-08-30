using Flags.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Flags.Services
{
    public class CountryService : ICountryService
    {
        private readonly IMongoCollection<Country> _countries;

        public CountryService(IOptions<CountryDatabaseSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            var database = client.GetDatabase(settings.Value.DatabaseName);
            _countries = database.GetCollection<Country>(settings.Value.CountryCollectionName);
        }

        public async Task<List<Country>> Get4(int id1, int id2, int id3, int id4)
        {
            List<Country> countries = new List<Country>
            {
               await _countries.Find(x => x.TheId == id1).FirstOrDefaultAsync(),
               await _countries.Find(_countries => _countries.TheId == id2).FirstOrDefaultAsync(),
               await _countries.Find(_countries => _countries.TheId == id3).FirstOrDefaultAsync(),
               await _countries.Find(_countries => _countries.TheId == id4).FirstOrDefaultAsync()
            };
            return countries;
        }

        public async Task<List<Country>> GetAll()
        {
            return await _countries.Find(_ => true).ToListAsync();
        }

        public async Task<List<Country>> GetByContinent(string continent)
        {
            continent = continent.ToLower();
            return await _countries.Find(country => country.Continent.ToLower() == continent).ToListAsync();
        }

        public async Task<Country> GetById(string id)
        {
            return await _countries.Find(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Country> GetByID(int id)
        {
            return await _countries.Find(x => x.TheId == id).FirstOrDefaultAsync();
        }

        public async Task<Country> GetByTld(string tld)
        {
            return await _countries.Find(x => x.tld == tld).FirstOrDefaultAsync();
        }
    }
}
