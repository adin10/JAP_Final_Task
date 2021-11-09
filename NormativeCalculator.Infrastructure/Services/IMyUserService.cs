using NormativeCalculator.Infrastructure.Dto;
using NormativeCalculator.Infrastructure.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Infrastructure.Services
{
   public interface IMyUserService
    {
        public Task<List<MyUserDto>> get(UserSearchRequest request);
    }
}
