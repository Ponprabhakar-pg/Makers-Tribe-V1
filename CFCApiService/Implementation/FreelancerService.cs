using CFCApiModal;
using CFCApiRepository.Interface;
using CFCApiService.Interface;

namespace CFCApiService
{
    public class FreelancerService: IFreelancerService
    {
        private readonly IFreelancerRepository _freelancerRepository;
        public FreelancerService(IFreelancerRepository freelancerRepository)
        {
            _freelancerRepository = freelancerRepository;
        }
        public bool RegisterFreelancer(FreelancerModal freelancerDetails)
        {
            return _freelancerRepository.RegisterFreelancer(freelancerDetails);
        }

        public string LoginUserManual(UserLoginModal userDetails)
        {
            return _freelancerRepository.LoginUserManual(userDetails);
        }

        public FreelancerModal GetFreelancerByMailId(string mailId)
        {
            return _freelancerRepository.GetFreelancerByMailId(mailId);
        }
    }
}
