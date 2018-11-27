using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AppServer.CustomerService.DomainModel
{
    public class Address : BaseEntity
    {
        public string City { get; set; }

        public Geography Location { get; set; } = new Geography();
    }

    [ComplexType]
    public class Geography
    {
        public double Lat { get; set; }

        public double Long { get; set; }
    }
}
