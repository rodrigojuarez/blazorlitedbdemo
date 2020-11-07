using System.Collections.Generic;

namespace ReqResLiteDb.Data
{
   public class UserResponse
   {
      public int Page { get; set; }
      public int PerPage { get; set; }
      public int Total { get; set; }
      public int TotalPages { get; set; }
      public IList<User> Data { get; set; }
   }
}
