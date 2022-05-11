using MongoDB.Bson;
using System;
using System.ComponentModel.DataAnnotations;

namespace CFCApiModal
{
    public class ProposalModal
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string OppourtunityId { get; set; }
        public string FreelancerMailId { get; set; }
        public string ClientMailId { get; set; }
        public string BidAmount { get; set; }
        public string BidDuration { get; set; }
        public string BidDescription { get; set; }
        public string CreatedAt { get; set; }
    }
}
