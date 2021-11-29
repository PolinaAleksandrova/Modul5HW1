using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul5HW1.Services;

namespace Modul5HW1
{
    public class Starter
    {
        public async Task Run()
        {
            var requestService = new RequestService();
            var getUsers = await requestService.GetUsers(2);
            var getUser = await requestService.GetUser(2);
            var create = await requestService.CreateUser("morpheus", "leader");
            var update = await requestService.UpdateUser(2, "morpheus", "zion resident");
            var patchUpdate = await requestService.PatchUpdateUser(2, "morpheus", "zion resident");
            var registerSuccessfull = await requestService.UserRegister("eve.holt@reqres.in", "pistol");
            var registerUnsuccessfull = await requestService.UserRegister("sydney@fife", null);
            var loginSuccessful = await requestService.Login("eve.holt@reqres.in", "cityslicka");
            var loginUnsuccessful = await requestService.Login("peter@klaven", null);
            var delayedResponse = await requestService.GetDelay(3);
        }
    }
}
