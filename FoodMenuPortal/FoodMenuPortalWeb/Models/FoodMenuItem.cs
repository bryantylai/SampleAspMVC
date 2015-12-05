namespace FoodMenuPortalWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FoodMenuItem")]
    public partial class FoodMenuItem
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public double Price { get; set; }

        public DateTime CreatedOn { get; set; }

        public Guid FoodMenuId { get; set; }
    }
}
