using MongoDB.Bson;

namespace JSApiModal
{
    public class ProposalModal
    {
        public ObjectId JobId { get; set; }
        public string JobSeekerMailId { get; set; }
        public string EmployerMailId { get; set; }
        public string CreatedAt { get; set; }
    }
}
