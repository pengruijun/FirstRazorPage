using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using FirstRazorPage.Models;

namespace FirstRazorPage.Services
{
    public interface IUserService
    {
        Task<List<User>> GetUsersAsync();
        Task<User> GetUserAsync(int id);
    }
}
