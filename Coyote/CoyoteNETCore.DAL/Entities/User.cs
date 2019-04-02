using System.Collections.Generic;

namespace CoyoteNETCore.DAL.Entities
{
    public class User
    {
        public long Id { get; set; }
        public virtual ICollection<Thread> Threads { get; set; }
    }
}