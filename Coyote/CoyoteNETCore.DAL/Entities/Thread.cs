using System;

namespace CoyoteNETCore.DAL.Entities
{
    public class Thread
    {
        public Thread()
        {
        }

        public long Id { get; set; }
        public string PublicId { get; set; }
        public string Brief { get; set; }
        public string Body { get; set; }
        public long AuthorId { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset? UpdateDate { get; set; }

        public virtual User Author { get; set; }
    }
}