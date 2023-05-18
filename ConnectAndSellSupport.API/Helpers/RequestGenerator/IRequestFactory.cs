using ConnectAndSellSupport.API.Models.Payload;



namespace ConnectAndSellSupport.API.Helpers.RequestGenerator
{
    public interface IRequestFactory
    {
        object GetRequest(BasePayload basePayload);
        
    }
}
