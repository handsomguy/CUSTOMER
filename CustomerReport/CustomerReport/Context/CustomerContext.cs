using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CustomerReport.Models;

namespace CustomerReport.Context
{
    public class CustomerContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }

    }
}