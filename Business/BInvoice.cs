using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Business
{
    public class BInvoice
    {
        public List<Invoice> GetByDate(DateTime dateTime)
        {
            DInvoice data = new DInvoice();
            var invoices = data.Get();
            var result = invoices.Where(x => x.Date == dateTime).ToList();

            return result;
        }
        public List<Invoice> Get()
        {
            DInvoice data = new DInvoice();
            var invoices = data.Get();

            return invoices;

        }
    }
}
