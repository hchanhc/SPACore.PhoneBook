using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace SPACore.PhoneBook.PhoneBooks.PhoneNumbers
{
    public class PhoneNumber : Entity<long>, IHasCreationTime
    {
        [Required]
        [MaxLength(11)]
        public string Number { get; set; }
        public PhoneType PhoneType { get; set; }
        public int PersonId { get; set; }
        public Persons.Person Person { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
