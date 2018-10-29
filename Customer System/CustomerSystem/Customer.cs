using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerSystem
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public char Gender { get; set; }
        public DateTime DateOfbirth { get; set; }

    }
    class CustomerBO
    {
        static List<Customer> customers = null;

        public CustomerBO()
        {
            cList = new List<Customer>();
            public bool AddCustomer(Customer custObj)
            {
                cList.Add(custObj);
            }
            public void ExportCustomerReport(string reportType)
            {
                if (reportType == "doc")
                {

                }
            }

        }
    }
}
