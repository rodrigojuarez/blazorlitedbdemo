using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReqResLiteDb.Data
{
   public class UserApiService
   {
      public async Task<IList<User>> GetUsers()
      {
         var client = new RestClient("https://reqres.in/api");

         var request = new RestRequest("/users", DataFormat.Json);

         var response = await client.GetAsync<UserResponse>(request);

         return response.Data;
      }
   }
}
