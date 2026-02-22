using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using Dapper;

namespace OfiangaLaundry.Repository.Interfaces
{
    public interface IRepository
    {
        // Used for getting laundry-related data
        Task<IEnumerable<T>> GetDataAsync<T>(
            string connectionString,
            string storedProcedure,
            DynamicParameters parameters = null);

        // Used for saving, updating, or deleting laundry data
        Task<bool> SaveDataAsync(
            string connectionString,
            string storedProcedure,
            DynamicParameters parameters = null);
    }
}