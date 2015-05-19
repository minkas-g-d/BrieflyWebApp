namespace Briefly.Models
{
    using System.Threading.Tasks;
    using System.Security.Claims;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Collections.Generic;
    using System;
    using System.ComponentModel.DataAnnotations;
    
    public class User : IdentityUser
    {
        private ICollection<Brief> briefs;
        private ICollection<User> followers;
        private ICollection<User> followees;

        public User()
        {
            this.briefs = new HashSet<Brief>();
            this.followers = new HashSet<User>();
            this.followees = new HashSet<User>();
        }


        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        [Required]
        public DateTime RegistrationDate { get; set; }

        public string ImageDataURL { get; set; }
        
        public string  Interests { get; set; }

        public int? CountryId { get; set; }

        public virtual Country Country { get; set; }

        public virtual ICollection<Brief> Briefs {
            get { return this.briefs; }
            set { this.briefs = value;  }
        }

        public virtual ICollection<User> Followers
        {
            get { return this.followers; }
            set { this.followers = value; }
        }

        public virtual ICollection<User> Followees
        {
            get { return this.followees; }
            set { this.followees = value; }
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}
