using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NormativeCalculator.Database;
using NormativeCalculator.Core.Models.Dto;
using NormativeCalculator.Infrastructure.Interfaces;
using NormativeCalculator.Core.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace NormativeCalculator.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly NCDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<IdentityUser> _userManager;
        public UserService(IMapper mapper, NCDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<List<MyUserDto>> Get(UserSearchRequest request)
        {
            var query =  _context.MyUsers.AsQueryable();
            if (request != null)
            {
                if (request.UserID.HasValue)
                {
                    query = query.Where(q => q.Id == request.UserID);
                }
            }
            var list = await query.ToListAsync();
            return _mapper.Map<List<MyUserDto>>(list);
        }

        public async Task<IdentityUser> LoggedUser()
        {
            var getUser = _httpContextAccessor.HttpContext.User.Identity;
            var user = await _userManager.FindByNameAsync(getUser.Name);

            return user;
        }
    }
}
