using MongoDB.Bson;
using System.Collections.Generic;

namespace JSApiModal
{
    public class JobModal
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string CTC { get; set; }
        public string ExperienceYears { get; set; }
        public List<string> Documents { get; set; }
        public int JobStatus { get; set; }
        public List<ObjectId> FinalizedJobSeekers { get; set; }
        public string CreatedAt { get; set; }
    }
}
