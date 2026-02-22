using OfiangaLaundry.Framework.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using OfiangaLaundry.Domain.Models;
using OfiangaLaundry.Repository.Interfaces;


namespace OfiangaLaundry.Framework.Queries
{
    public class GetLaundryOrderById
    {
        private readonly string _connectionName = "Default Connection";
        private readonly string _storedProcedure;
        private readonly IRepository _repository;

        public GetLaundryOrderById(IRepository repository)
        {
            _storedProcedure = "[dbo].[GetLaundryOrderById]";
            _repository = repository;
        }

        public async Task<LaundryOrderModel?> ExecuteAsync(string orderId)
        {
            var parameters = orderId.ToDynamicParameters("OrderID");

            var result = await _repository.GetDataAsync<LaundryOrderModel>(
                _connectionName,
                _storedProcedure,
                parameters
            );

            return result.FirstOrDefault();
        }
    }
}
