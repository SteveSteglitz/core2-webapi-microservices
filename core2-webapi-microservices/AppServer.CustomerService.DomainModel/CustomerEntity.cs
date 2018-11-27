using System;
using System.Collections.Generic;
using System.Text;

namespace AppServer.CustomerService.DomainModel
{
    public class CustomerEntity : BaseEntity
    {
        //[Required] alternative zur FluentAPI (OnModelCreating)
        public string Name { get; set; }

        public ICollection<Address> Addresses { get; set; } = new HashSet<Address>();

        public bool Active { get; set; }
    }
}
