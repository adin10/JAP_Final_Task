using Microsoft.AspNetCore.Identity;
using NormativeCalculator.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Core.Entities
{
    public class MyUser:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserId { get; set; }
        public IdentityUser<int> User { get; set; }

    }
}
