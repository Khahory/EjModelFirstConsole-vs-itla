using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjModelFirstConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AccontingSystemContainer())
            {
                var invHeader = db.InvoiceHeaderSet.Create();
                var invDetail = db.InvoiceDetailSet.Create();

                invHeader.Total = 150m;


                invDetail.ItemDescriptions = "Some Item";
                invDetail.Price = 75m;
                invDetail.Quantity = 2;

                invHeader.InvoiceDetail.Add(invDetail);

                db.InvoiceHeaderSet.Add(invHeader);
                db.SaveChanges();

            }


        }
    }
}
