using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace SPACore.PhoneBook.PhoneBooks.Persons
{
    public class Person : FullAuditedEntity
    {
        [Required]
        [MaxLength(PhoneBookConsts.MaxPersonNameLength)]
        public string Name { get; set; }
        [EmailAddress]
        [MaxLength(PhoneBookConsts.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
        [MaxLength(PhoneBookConsts.MaxAddressLength)]
        public string Address { get; set; }
    }
}
