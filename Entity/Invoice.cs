using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Invoice
    {
        public int Invoice_Id { get; set; }
        public int Customer_Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public bool Active { get; set; }
    }
}
