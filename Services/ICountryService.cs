using Flags.Models;

namespace Flags.Services
{
    public interface ICountryService
    {
        Task<List<Country>> GetAll();
        Task<Country> GetById(string id);
        Task<Country> GetByID(int id);
        Task<Country> GetByTld(string tld);
        Task<List<Country>> GetByContinent(string continent);

        Task<List<Country>> Get4(int id1,int id2,int id3,int id4);
    }
}
