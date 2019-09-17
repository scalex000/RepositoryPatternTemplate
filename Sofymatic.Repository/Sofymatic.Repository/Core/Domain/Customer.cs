using System;
using System.Collections.Generic;
using System.Text;

namespace Sofymatic.Repository.Core.Domain
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
