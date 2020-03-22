namespace ConferenceScheduler.Data.Models
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Identity;

    public class ApplicationUser : IdentityUser<string>
    {
        public ApplicationUser()
        {
            this.UsersConferences = new HashSet<UsersConferences>();
        }

        public virtual ICollection<UsersConferences> UsersConferences { get; set; }
    }
}
