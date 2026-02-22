using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace OfiangaLaundry.Framework.Extensions
{
    public static class StringExtension
    {
        // Used for searching laundry orders (Receipt No, Order ID, etc.)
        public static DynamicParameters ToDynamicParameters(this string value, string parameterName)
        {
            var parameters = new DynamicParameters();
            parameters.Add($"@{parameterName}", value, DbType.String, ParameterDirection.Input);
            return parameters;
        }
    }
}
