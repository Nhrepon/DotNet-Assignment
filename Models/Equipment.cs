using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet_Assignment.Models
{
    public class Equipment
    {
        [Key]
        public int EquipmentId { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; } = "";
        [MaxLength(100)]
        public string Description { get; set; } = "";
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int CustomerId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public required Customer customer { get; set; }
    }
}