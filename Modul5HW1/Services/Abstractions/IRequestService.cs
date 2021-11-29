using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul5HW1.Models.MethodGet;
using Modul5HW1.Models.OtherMethods;

namespace Modul5HW1.Services.Abstractions
{
    public interface IRequestService
    {
        public Task<ListData<User>> GetUsers(int page);
        public Task<SingleData<User>> GetUser(int id);
        public Task<UserCreateInfo> CreateUser(string name, string job);
        public Task<UserCreateInfo> UpdateUser(int id, string name, string job);
        public Task<UserCreateInfo> PatchUpdateUser(int id, string name, string job);
        public Task<Registration> UserRegister(string email, string password);
        public Task<Registration> Login(string email, string password);
        public Task<ListData<User>> GetDelay(int delay);
    }
}
