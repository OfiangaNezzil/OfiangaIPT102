using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfiangaLaundry.Domain.Commands;
using OfiangaLaundry.Domain.Models;
using OfiangaLaundry.Framework.Extensions;
using OfiangaLaundry.Repository.Interfaces;

namespace OfiangaLaundry.Framework.Commands
{
    public class DeleteLaundryOrder : IDeleteLaundryOrder
    {
        private readonly string _connectionName = "Default Connection";
        private readonly string _storedProcedure;
        private readonly IRepository _repository;

        public DeleteLaundryOrder(IRepository repository)
        {
            _storedProcedure = "[dbo].[DeleteLaundryOrder]";
            _repository = repository;
        }

        public async Task<bool> ExecuteAsync(LaundryOrderModel model)
        {
            var parameters = model.ToLaundryOrderDynamicParameters();
            return await _repository.SaveDataAsync(
                _connectionName,
                _storedProcedure,
                parameters
            );
        }
    }
}