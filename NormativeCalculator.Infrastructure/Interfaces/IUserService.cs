using NormativeCalculator.Core.Models.Dto;
using NormativeCalculator.Core.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Infrastructure.Interfaces
{
   public interface IUserService
    {
        public Task<List<MyUserDto>> Get(UserSearchRequest request);
    }
}
