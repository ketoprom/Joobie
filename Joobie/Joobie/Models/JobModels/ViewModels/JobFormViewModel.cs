﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Joobie.Models.JobModels.ViewModels
{
    public class JobFormViewModel
    {
        public Job Job { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<TypeOfContract> TypesOfContract { get; set; }
        public IEnumerable<WorkingHours> WorkingHours { get; set; }
        public IEnumerable<ApplicationUser> ApplicationUser { get; set; }
    }
}
