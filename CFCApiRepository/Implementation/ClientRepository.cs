using CFCApiModal;
using CFCApiRepository.Interface;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace CFCApiRepository.Implementation
{
    public  class ClientRepository: IClientRepository
    {
        private readonly CFCMongoDbContext _cfcMongoDbContext;

        public ClientRepository(CFCMongoDbContext cfcMongoDbContext)
        {
            _cfcMongoDbContext = cfcMongoDbContext;
        }

        public bool RegisterClient(ClientModal clientDetails)
        {
            var checkExistance = _cfcMongoDbContext.LoginData.Find(x => x.MailId == clientDetails.MailId).FirstOrDefault();
            if (checkExistance != null)
                return false;
            clientDetails.CreatedAt = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            clientDetails.AccountStatus = 0;
            clientDetails.MailVerificationStatus = 0;
            var loginData = new UserLoginModal
            {
                MailId = clientDetails.MailId,
                Password = clientDetails.Password,
                AccountCreationType = clientDetails.AccountCreationType,
                UserType = clientDetails.UserType,
            };
            _cfcMongoDbContext.LoginData.InsertOne(loginData);
            _cfcMongoDbContext.ClientData.InsertOne(clientDetails);
            return true;
        }

        public ClientModal GetClientByMailId(string mailId)
        {
            var clientData = _cfcMongoDbContext.ClientData.Find(x => x.MailId == mailId).FirstOrDefault();
            clientData.Password = "*******";
            return clientData;
        }

    }
}
