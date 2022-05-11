using MongoDB.Driver;
using CFCApiModal;

namespace CFCApiRepository
{
    public class CFCMongoDbContext
    {
        public IMongoCollection<FreelancerModal> FreelancerData { get; }
        public IMongoCollection<ClientModal> ClientData { get; }
        public IMongoCollection<UserLoginModal> LoginData { get; }
        public IMongoCollection<OppourtunityModal> OppourtunityData { get; }
        public IMongoCollection<ProposalModal> ProposalData { get; }
        public IMongoCollection<SuperAdminModal> SuperAdminData { get; }
        public CFCMongoDbContext()
        {
            var client = new MongoClient("mongodb+srv://prabha:prabha123@cluster0.uvmcv.mongodb.net/");
            var database = client.GetDatabase("ChennaiFreelancersClub");
            FreelancerData = database.GetCollection<FreelancerModal>("FreelancerData");
            ClientData = database.GetCollection<ClientModal>("ClientData");
            LoginData = database.GetCollection<UserLoginModal>("LoginData");
            OppourtunityData = database.GetCollection<OppourtunityModal>("OppourtunityData");
            ProposalData = database.GetCollection<ProposalModal>("ProposalData");
            SuperAdminData = database.GetCollection<SuperAdminModal>("SuperAdminData");
        }
    }
}
