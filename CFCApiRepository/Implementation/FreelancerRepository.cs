using CFCApiModal;
using CFCApiRepository.Interface;
using MongoDB.Driver;
using System;

namespace CFCApiRepository
{
    public class FreelancerRepository: IFreelancerRepository
    {
        private readonly CFCMongoDbContext _cfcMongoDbContext;

        public FreelancerRepository(CFCMongoDbContext cfcMongoDbContext)
        {
            _cfcMongoDbContext = cfcMongoDbContext;
        }

        public bool RegisterFreelancer(FreelancerModal freelancerDetails)
        {
            var checkExistance = _cfcMongoDbContext.LoginData.Find(x => x.MailId == freelancerDetails.MailId).FirstOrDefault();
            if (checkExistance != null)
                return false;
            freelancerDetails.CreatedAt = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            freelancerDetails.AccountStatus = 0;
            freelancerDetails.MailVerificationStatus = 0;
            var loginData = new UserLoginModal {
                MailId = freelancerDetails.MailId,
                Password = freelancerDetails.Password,
                AccountCreationType = freelancerDetails.AccountCreationType,
                UserType = freelancerDetails.UserType,
            };
            _cfcMongoDbContext.LoginData.InsertOne(loginData);
            _cfcMongoDbContext.FreelancerData.InsertOne(freelancerDetails);
            return true;
        }

        public string LoginUserManual(UserLoginModal userDetails)
        {
            var loginData = _cfcMongoDbContext.LoginData.Find(x => x.MailId == userDetails.MailId).FirstOrDefault();
            if (loginData != null)
            {
                if(userDetails.Password == loginData.Password)
                {
                    return loginData.UserType;
                }
                return "failed";
            }
            return "not exist";
        }

        public FreelancerModal GetFreelancerByMailId(string mailId)
        {
            var freelancerData = _cfcMongoDbContext.FreelancerData.Find(x => x.MailId == mailId).FirstOrDefault();
            freelancerData.Password = "*******";
            return freelancerData;
        }
    }
}
