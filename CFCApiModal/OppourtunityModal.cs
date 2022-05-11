using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CFCApiModal
{
    public class OppourtunityModal
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Amount { get; set; }
        public string Duration { get; set; }
        public List<string> Documents { get; set; }
        public int OppourtunityStatus { get; set; }
        public string AcceptedProposalId { get; set; }
        public string CreatedAt { get; set; }
    }
}
