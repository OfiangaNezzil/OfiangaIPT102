using OfiangaLaundry.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfiangaLaundry.Domain.Queries
{
    public interface IGetLaundryOrderById
    {
        Task<LaundryOrderModel?> ExecuteAsync(string orderId);
    }
}