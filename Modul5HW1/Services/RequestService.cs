using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Modul5HW1.Models.MethodGet;
using Newtonsoft.Json;
using Modul5HW1.Models.OtherMethods;
using Modul5HW1.Services.Abstractions;

namespace Modul5HW1.Services
{
    public class RequestService : IRequestService
    {
        private HttpClient _client = new HttpClient();
        public async Task<UserCreateInfo> CreateUser(string name, string job)
        {
            var url = $"https://reqres.in/api/users";
            var content = JsonConvert.SerializeObject(new { Name = name, Job = job });
            var data = await GetJson(url, HttpMethod.Post, content);

            var user = JsonConvert.DeserializeObject<UserCreateInfo>(data);

            return user;
        }

        public async Task<UserCreateInfo> UpdateUser(int id, string name, string job)
        {
            var url = $"https://reqres.in/api/users/{id}";
            var content = JsonConvert.SerializeObject(new { Name = name, Job = job });
            var data = await GetJson(url, HttpMethod.Put, content);

            var user = JsonConvert.DeserializeObject<UserCreateInfo>(data);

            return user;
        }

        public async Task<UserCreateInfo> PatchUpdateUser(int id, string name, string job)
        {
            var url = $"https://reqres.in/api/users/{id}";
            var content = JsonConvert.SerializeObject(new { Name = name, Job = job });
            var data = await GetJson(url, HttpMethod.Patch, content);

            var user = JsonConvert.DeserializeObject<UserCreateInfo>(data);

            return user;
        }

        public async Task<Registration> UserRegister(string email, string password)
        {
            var url = $"https://reqres.in/api/register";
            var content = JsonConvert.SerializeObject(new { Email = email, Password = password });
            var data = await GetJson(url, HttpMethod.Post, content);

            var user = JsonConvert.DeserializeObject<Registration>(data);

            return user;
        }

        public async Task<Registration> Login(string email, string password)
        {
            var url = $"https://reqres.in/api/login";
            var content = JsonConvert.SerializeObject(new { Email = email, Password = password });
            var data = await GetJson(url, HttpMethod.Post, content);

            var registerUser = JsonConvert.DeserializeObject<Registration>(data);

            return registerUser;
        }

        public async Task<ListData<User>> GetDelay(int delay)
        {
            var url = $"https://reqres.in/api/users?delay={delay}";
            var data = await GetJson(url, HttpMethod.Get);
            var page = JsonConvert.DeserializeObject<ListData<User>>(data);

            return page;
        }

        public async Task<SingleData<User>> GetUser(int id)
        {
            var url = $"https://reqres.in/api/users/{id}";
            var data = await GetJson(url, HttpMethod.Get);

            var user = JsonConvert.DeserializeObject<SingleData<User>>(data);

            return user;
        }

        public async Task<ListData<User>> GetUsers(int page)
        {
            var url = $"https://reqres.in/api/users?page={page}";
            var data = await GetJson(url, HttpMethod.Get);

            var users = JsonConvert.DeserializeObject<ListData<User>>(data);

            return users;
        }

        private async Task<string> GetJson(string url, HttpMethod methods, string content = null)
        {
            var method = methods;
            var data = await CreateMessage(method, content);
            return data;
        }

        private async Task<string> CreateMessage(HttpMethod methodType, string content = null)
        {
            var message = new HttpRequestMessage();

            message.Method = methodType;
            message.Content = new StringContent(content);
            var response = await _client.SendAsync(message);
            var data = await response.Content.ReadAsStringAsync();

            return data;
        }
    }
}