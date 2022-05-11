using CFCApiModal;
using System.Collections.Generic;

namespace CFCApiRepository.Interface
{
    public interface IClientRepository
    {
        bool RegisterClient(ClientModal clientDetails);
        ClientModal GetClientByMailId(string mailId);
    }
}
