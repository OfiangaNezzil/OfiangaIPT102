using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using OfiangaLaundry.Domain.Models;

namespace OfiangaLaundry.Framework.Extensions
{
    public static class LaundryOrderExtension
    {
        public static DynamicParameters ToLaundryOrderDynamicParameters(this LaundryOrderModel model)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@OrderID", model.OrderID, DbType.String);
            parameters.Add("@ReceiptNumber", model.ReceiptNumber, DbType.String);
            parameters.Add("@CustomerName", model.CustomerName, DbType.String);
            parameters.Add("@ServiceType", model.ServiceType, DbType.String);
            parameters.Add("@WeightInKg", model.WeightInKg, DbType.Decimal);
            parameters.Add("@TotalPrice", model.TotalPrice, DbType.Decimal);
            parameters.Add("@Status", model.Status, DbType.String);

            return parameters;
        }
    }
}