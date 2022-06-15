using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeCongCompany.LeCongTemplate.Phone
{
    [Table("PbPhones")]
    public class Phone : CreationAuditedEntity<long>
    {

        [ForeignKey("PersonId")]
        public virtual Person.Person Person { get; set; }
        public virtual int PersonId { get; set; }

        [Required]
        public virtual PhoneType Type { get; set; }

        [Required]
        [MaxLength(PhoneConsts.MaxNumberLength)]
        public virtual string Number { get; set; }
    }
}
