using LeCongCompany.LeCongTemplate.EntityFrameworkCore;
using LeCongCompany.LeCongTemplate.Phone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeCongCompany.LeCongTemplate.Migrations.Seed.Host
{
    public class InitialPeopleAndPhoneCreator
    {
        //...
        private readonly LeCongTemplateDbContext _context;

        public InitialPeopleAndPhoneCreator(LeCongTemplateDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            var douglas = _context.Persons.FirstOrDefault(p => p.EmailAddress == "douglas.adams@fortytwo.com");
            if (douglas == null)
            {
                _context.Persons.Add(
                    new Person.Person
                    {
                        Name = "Douglas",
                        Surname = "Adams",
                        EmailAddress = "douglas.adams@fortytwo.com",
                        Phones = new List<Phone.Phone>
                                    {
                                    new Phone.Phone {Type = PhoneType.Home, Number = "1112242"},
                                    new  Phone.Phone {Type = PhoneType.Mobile, Number = "2223342"}
                                    }
                    });
            }

            var asimov = _context.Persons.FirstOrDefault(p => p.EmailAddress == "isaac.asimov@foundation.org");
            if (asimov == null)
            {
                _context.Persons.Add(
                    new Person.Person
                    {
                        Name = "Isaac",
                        Surname = "Asimov",
                        EmailAddress = "isaac.asimov@foundation.org",
                        Phones = new List<Phone.Phone>
                                    {
                                    new Phone.Phone {Type = PhoneType.Home, Number = "8889977"}
                                    }
                    });
            }
        }
    }

}
