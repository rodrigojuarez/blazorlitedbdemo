using LiteDB;
using System.Threading.Tasks;

namespace ReqResLiteDb.Data
{
   public class UserPersistenceService
   {
      readonly LiteDatabase _db;
      readonly UserApiService userApiService;

      public UserPersistenceService(UserApiService userApiService)
      {
         this.userApiService = userApiService;
         _db = new LiteDatabase("Filename=ReqResLiteDB.db;connection=shared");
         Users.EnsureIndex(x => x.Id);
      }

      public ILiteCollection<User> Users => _db.GetCollection<User>();


      public async Task ImportFromApi()
      {
         Users.DeleteAll();
         var users = await userApiService.GetUsers();
         Users.InsertBulk(users);
      }

      public void DeleteAll()
      {
         Users.DeleteAll();
      }

      public void Delete(int id)
      {
         Users.Delete(id);
      }

   }
}