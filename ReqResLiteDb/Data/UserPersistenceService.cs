using System.Threading.Tasks;

namespace ReqResLiteDb.Data
{
   public class UserPersistenceService
   {
      private readonly UserApiService userApiService;

      public UserPersistenceService(UserApiService userApiService)
      {
         this.userApiService = userApiService;
      }

      public async Task ImportFromApi()
      {
         var users = await userApiService.GetUsers();

         // TODO: to litedb
      }
   }
}