using System;
using System.Collections.Generic;

namespace Domain.Core.User
{
    public class User
    {
        public User()
        {
            Contracts = new HashSet<UserContract>();
        }

        public Int32 Id { get; set; }
        public string FirstName { get; set; }
        public string ParentMidleName { get; set; }
        public string LastName { get; set; }
        public Guid Guid { get; set; }
        public string Email { get; set; }

        public virtual UserPhoto Photo { get; set; }
        public virtual UserProfile Profile { get; set; }
        public virtual UserLocation Location { get; set; }

        public virtual ICollection<UserContract> Contracts { get; set; }
        public virtual ICollection<UserCard> Cards { get; set; }
    }
}
