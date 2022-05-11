using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CFCApiModal
{
    public class ClientModal
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString(); 
        public string Name { get; set; }
        public string MailId { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string DOB { get; set; }
        public string Description { get; set; }
        public List<string> ExpectedSkills { get; set; }
        public string UserType { get; set; } = "Client";
        public string AccountCreationType { get; set; }
        public int MailVerificationStatus { get; set; }
        public int AccountStatus { get; set; }
        public string ProfilePicture { get; set; }
        public List<string> PostedOppourtunities { get; set; }
        public List<string> OngoingOppourtunities { get; set; }
        public List<string> FinishedOppourtunities { get; set; }
        public List<FeedbackModal> Feedbacks { get; set; }
        public string CreatedAt { get; set; }
    }
}