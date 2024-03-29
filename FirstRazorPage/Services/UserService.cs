﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

using Newtonsoft.Json;
using FirstRazorPage.Models;

namespace FirstRazorPage.Services
{
    public class UserService : IUserService
    {
        public async Task<User> GetUserAsync(int id)
        {
            using(var client = new HttpClient())
            {
                var endPoint = $"https://jsonplaceholder.typicode.com/users/{id}";
                var json = await client.GetStringAsync(endPoint);
                return JsonConvert.DeserializeObject<User>(json);
            }
        }

        public async Task<List<User>> GetUsersAsync()
        {
            using (var client = new HttpClient())
            {
                var endPoint = "https://jsonplaceholder.typicode.com/users";
                var json = await client.GetStringAsync(endPoint);
                return JsonConvert.DeserializeObject<List<User>>(json);
            }
        }
    }
}
