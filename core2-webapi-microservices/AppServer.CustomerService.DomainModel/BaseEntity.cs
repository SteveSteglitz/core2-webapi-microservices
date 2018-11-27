namespace AppServer.CustomerService.DomainModel
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public class BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
}
