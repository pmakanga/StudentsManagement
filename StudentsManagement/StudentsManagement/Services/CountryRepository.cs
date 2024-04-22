using Microsoft.EntityFrameworkCore;
using StudentsManagement.Data;
using StudentsManagement.Shared.Models;
using StudentsManagement.Shared.StudentsRepository;

namespace StudentsManagement.Services
{
    public class CountryRepository : ICountryRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public CountryRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Country> AddCountryAsync(Country country)
        {
            if(country == null) throw new ArgumentNullException();
            var newCountry = _dbContext.Countries.Add(country).Entity;
            await _dbContext.SaveChangesAsync();
            return newCountry;
        }

        public async Task<Country> DeleteCountryAsync(Guid countryId)
        {
            var country = await _dbContext.Countries.Where(_ => _.Id == countryId).FirstOrDefaultAsync();
            if (country == null) throw new ArgumentNullException();

            _dbContext.Countries.Remove(country);
            await _dbContext.SaveChangesAsync();
            return country;
        }

        public async Task<List<Country>> GetAllCountriesAsync()
        {
            var countries = await _dbContext.Countries.ToListAsync();
            return countries;
        }

        public async Task<Country> GetCountryByIdAsync(Guid countryId)
        {
            var country = await _dbContext.Countries.Where(_ => _.Id == countryId).FirstOrDefaultAsync();
            if (country == null) throw new ArgumentNullException();

            return country;
        }

        public async Task<Country> UpdateCountryAsync(Country country)
        {
            if (country == null) throw new ArgumentNullException();
            var _country = _dbContext.Countries.Update(country).Entity;
            await _dbContext.SaveChangesAsync();
            return _country;
        }
    }
}
