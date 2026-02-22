using OfiangaLaundry.Framework.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfiangaLaundry.Domain.Models;
using OfiangaLaundry.Domain.Queries;
using OfiangaLaundry.Repository.Interfaces;

namespace OfiangaLaundry.Framework.Queries
{
    public class GetLaundryOrderByReceipt : IGetLaundryOrderByReceipt
    {
        private readonly string _connectionName = "Default Connection";
        private readonly string _storedProcedure;
        private readonly IRepository _repository;

        public GetLaundryOrderByReceipt(IRepository repository)
        {
            _storedProcedure = "[dbo].[GetLaundryOrderByReceipt]";
            _repository = repository;
        }

        public async Task<LaundryOrderModel?> ExecuteAsync(string receiptNumber)
        {
            var parameters = receiptNumber.ToDynamicParameters("ReceiptNumber");

            var result = await _repository.GetDataAsync<LaundryOrderModel>(
                _connectionName,
                _storedProcedure,
                parameters
            );

            return result.FirstOrDefault();
        }
    }
}
