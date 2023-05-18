using System.Collections.Generic;

namespace ConnectAndSellSupport.Services.Models.Response.List
{
    public class ListServiceResponse : BaseServiceResponse
    {
        public List<ListDetails> Lists { get; set; }

        public bool ListsNotFound { get; set; }
    }
}
