using MongoDB.Bson;
using System;
using System.Collections.Generic;

namespace JSApiModal
{
    public class EmployerModal
    {
        public string Name { get; set; }
        public string MailId { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Designation { get; set; }
        public string LinkedIn { get; set; }
        public Organization OrganizationDetails { get; set; }
        public string DOB { get; set; }
        public string Description { get; set; }
        public string AccountCreationType { get; set; }
        public int MailVerificationStatus { get; set; }
        public int AccountStatus { get; set; }
        public string ProfilePicture { get; set; }
        public List<ObjectId> PostedJobs { get; set; }
        public List<ObjectId> OnprogressJobs { get; set; }
        public List<ObjectId> FinalizedJobs { get; set; }
        public List<FeedbackModal> Feedbacks { get; set; }
        public string CreatedAt { get; set; }
    }
}

public class Organization
{
    public string Name { get; set; }
    public string Location { get; set; }
    public string Email { get; set; }
    public string LinkedIn {get; set; }
    public string Website { get; set; }
}