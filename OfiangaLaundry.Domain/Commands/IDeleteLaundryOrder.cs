using OfiangaLaundry.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfiangaLaundry.Domain.Commands
{
    public interface IDeleteLaundryOrder
    {
        Task<bool> ExecuteAsync(LaundryOrderModel model);
    }
}
