using ReportingApp.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportingApp.DAL.Repository
{
    public class CustomerRepository
    {
        WideWorldImportersContext _context;
        public CustomerRepository()
        {
            _context = new WideWorldImportersContext();
        }

        public List<Customer> getCustomers()
        {
            return _context.Customers.Take(20).ToList();
        }
    }
}
