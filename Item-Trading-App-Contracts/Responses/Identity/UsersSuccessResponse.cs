using System.Collections.Generic;

namespace Item_Trading_App_Contracts.Responses.Identity
{
    public class UsersSuccessResponse
    {
        public IEnumerable<string> UsersId { get; set; }
    }
}
