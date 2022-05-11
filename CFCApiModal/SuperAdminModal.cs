using MongoDB.Bson;
using System;
using System.ComponentModel.DataAnnotations;

namespace CFCApiModal
{
    public class SuperAdminModal
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string MailId { get; set; }
        public string PhoneNumber { get; set; }
        public string AccountCreationType = "Manual";
        public string CreatedAt { get; set; }
    }
}
