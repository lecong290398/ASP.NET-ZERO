﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeCongCompany.LeCongTemplate.Person.Dto
{
    public class GetPersonForEditOutput
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }

        public string EmailAddress { get; set; }
    }
}
