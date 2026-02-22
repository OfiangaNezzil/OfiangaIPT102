using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfiangaLaundry.Domain.Models
{
    public class LaundryOrderModel
    {
        public string OrderID { get; set; }
        public string ReceiptNumber { get; set; }
        public string CustomerName { get; set; }
        public string ServiceType { get; set; }
        public decimal WeightInKg { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }
    }
}
