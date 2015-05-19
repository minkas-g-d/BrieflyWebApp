namespace Briefly.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Brief
    {
        private ICollection<Brief> childBriefs;

        public Brief()
        {
            this.childBriefs = new HashSet<Brief>();
        }

        public int Id { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(140)]
        public string Content { get; set; }

        public string ImageDataURL { get; set; }

        [Required]
        public int AuthourId { get; set; }

        // Add default value 0
        public int ParentId { get; set; }

        // Add default value 0
        public int FacebookShares { get; set; }

        // Add default value 0
        public int Favoured { get; set; }

        [Required]
        public DateTime PublishDate { get; set; }

        public virtual ICollection<Brief> ChildBriefs 
        {
            get { return this.childBriefs; }
            set { this.childBriefs = value;  }
        }
        
    }
}
