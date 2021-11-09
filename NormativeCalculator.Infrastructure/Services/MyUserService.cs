using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NormativeCalculator.Infrastructure.Context;
using NormativeCalculator.Infrastructure.Dto;
using NormativeCalculator.Infrastructure.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Infrastructure.Services
{
    public class MyUserService : IMyUserService
    {
        private readonly IMapper _mapper;
        private readonly MyContext _context;

        public MyUserService(IMapper mapper, MyContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<List<MyUserDto>> get(UserSearchRequest request)
        {
            var query =  _context.MyUser.AsQueryable();
            if (request != null)
            {
                if (request.UserID.HasValue)
                {
                    query = query.Where(q => q.MyUserId == request.UserID);
                }
            }
            var list = await query.ToListAsync();
            return _mapper.Map<List<MyUserDto>>(list);
        }
    }
}
