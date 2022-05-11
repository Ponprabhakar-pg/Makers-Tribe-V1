using CFCApiModal;

namespace CFCApiRepository.Interface
{
    public interface IFreelancerRepository
    {
        bool RegisterFreelancer(FreelancerModal freelancerDetails);
        string LoginUserManual(UserLoginModal userDetails);
        FreelancerModal GetFreelancerByMailId(string mailId);
    }
}
