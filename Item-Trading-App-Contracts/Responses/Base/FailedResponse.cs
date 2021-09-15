using System.Collections.Generic;

namespace Item_Trading_App_Contracts.Responses.Base
{
    // the default response base class for errors
    public class FailedResponse
    {
        public IEnumerable<string> Errors { get; set; }
    }
}
