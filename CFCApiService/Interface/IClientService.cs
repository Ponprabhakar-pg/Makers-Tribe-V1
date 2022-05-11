using CFCApiModal;

namespace CFCApiService.Interface
{
    public interface IClientService
    {
        bool RegisterClient(ClientModal clientDetails);
        ClientModal GetClientByMailId(string mailId);
    }
}
