using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace NormativeCalculator.Database
{
    public class MyUser
    {
        public int MyUserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserId { get; set; }
        public IdentityUser<int> User { get; set; }

    }
}
