

using MongoDB.Bson;
using System.Collections.Generic;

namespace JSApiModal
{
    public class JobSeekerModal
    {
        public string Name { get; set; }
        public string MailId { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string DOB { get; set; }
        public string Description { get; set; }
        public List<string> Skills { get; set; }
        public string AccountCreationType { get; set; }
        public int MailVerificationStatus { get; set; }
        public int AccountStatus { get; set; }
        public string ProfilePicture { get; set; }
        public string Resume { get; set; }
        public List<ObjectId> AppliedOffers { get; set; }
        public List<ObjectId> OnprogressOffers { get; set; }
        public List<ObjectId> ReceivedOffers { get; set; }
        public List<FeedbackModal> Feedbacks { get; set; }
        public string CreatedAt { get; set; }
    }
}
