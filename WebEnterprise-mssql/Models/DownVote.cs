using System;

namespace WebEnterprise_mssql.Models
{
    public class DownVote
    {
        public Guid ID { get; set; }
        public string userId { get; set; }
        public Guid voteId { get; set; }
        public virtual Votes Votes { get; set; }
    }
}