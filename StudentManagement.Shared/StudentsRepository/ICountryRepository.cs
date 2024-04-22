using StudentsManagement.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagement.Shared.StudentsRepository
{
    public interface ICountryRepository
    {
        Task<Country> AddCountryAsync(Country country);
        Task<Country> UpdateCountryAsync(Country country);
        Task<List<Country>> GetAllCountriesAsync();
        Task<Country> GetCountryByIdAsync(Guid countryId);
        Task<Country> DeleteCountryAsync(Guid countryId);

    }
}
