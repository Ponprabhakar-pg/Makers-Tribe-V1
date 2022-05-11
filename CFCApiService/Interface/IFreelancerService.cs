using CFCApiModal;
using System.Collections.Generic;

namespace CFCApiService.Interface
{
    public interface IFreelancerService
    {
        bool RegisterFreelancer(FreelancerModal freelancerDetails);
        string LoginUserManual(UserLoginModal userDetails);
        FreelancerModal GetFreelancerByMailId(string mailId);
    }
}
