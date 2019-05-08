using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTracker.Models;

namespace TimeTracker.Services
{
    public interface IUserService
    {
        Task<User> RegisterUser(User user);
    }
}
