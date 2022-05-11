using System;
using System.Collections.Generic;
using System.Text;
using CFCApiRepository.Interface;
using CFCApiModal;
using CFCApiService.Interface;
using Microsoft.AspNetCore.Http;
using Ganss.Excel;
using System.Linq;

namespace CFCApiService
{
    public class ClientService: IClientService
    {
        private readonly IClientRepository _clientRepository;
        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public bool RegisterClient(ClientModal clientDetails)
        {
            return _clientRepository.RegisterClient(clientDetails);
        }

        public ClientModal GetClientByMailId(string mailId)
        {
            return _clientRepository.GetClientByMailId(mailId);
        }

    }
}
