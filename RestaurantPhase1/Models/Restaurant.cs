namespace RestaurantPhase1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Restaurant
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RestaurantId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(50)]
        public string Area { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Image1 { get; set; }

        [StringLength(50)]
        public string Image2 { get; set; }

        [StringLength(50)]
        public string Image3 { get; set; }

        [StringLength(50)]
        public string Image4 { get; set; }
    }
}
