using OfiangaLaundry.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfiangaLaundry.Domain.Queries
{
    public interface IGetLaundryOrderByReceipt
    {
        Task<LaundryOrderModel?> ExecuteAsync(string receiptNumber);
    }
}